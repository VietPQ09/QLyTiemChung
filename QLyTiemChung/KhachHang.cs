using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLyTiemChung
{
    public partial class KhachHang : Form
    {
        SqlConnection conn = Connection.GetSqlConnection();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng kí khám không ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) ;
            PhieuKham phieuKham = new PhieuKham();
            Form1 parentFrom = this.ParentForm as Form1;
            parentFrom.OpenChildForm(phieuKham);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            DateTime ngaySinh = dtPNgSinh.Value;
            string gioiTinh = checknam.Checked ? "Nam" : "Nữ";
            string diaChi = txtDC.Text;
            string soDienThoai = maskTxtSDT.Text;
            string nguoiGiamHo = txtNgGH.Text;
            string cccd = txtCCCD.Text;

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = Connection.stringConnection;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertCustomers", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền các tham số vào stored procedure
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@TenKH", tenKH);
                    command.Parameters.AddWithValue("@NgSinh", ngaySinh);
                    command.Parameters.AddWithValue("@GT", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@Sdt", soDienThoai);
                    command.Parameters.AddWithValue("@NgGH", nguoiGiamHo);
                    command.Parameters.AddWithValue("@CCCD", cccd);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        // Sau khi thêm thành công, có thể làm mới danh sách khách hàng hoặc làm các tác vụ khác cần thiết.
                        LoadCustomerData(); // Load lại dữ liệu để cập nhật DataGridView
                        ClearInputs(); // Xóa dữ liệu trong các điều khiển để chuẩn bị cho việc nhập mới
                        PhieuKham phieuKham = new PhieuKham();
                        Form1 parentFrom = this.ParentForm as Form1;
                        parentFrom.OpenChildForm(phieuKham);
                        this.Hide();
                             
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void ClearInputs()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            dtPNgSinh.Value = DateTime.Now;
            checknam.Checked = true;
            txtDC.Text = "";
            maskTxtSDT.Text = "";
            txtNgGH.Text = "";
            txtCCCD.Text = "";
        }
        // Load dữ liệu khách hàng 
        private void LoadCustomerData()
        {
            string connectionString = Connection.stringConnection;
            string query = "SELECT * FROM Khach_Hang"; // Điều chỉnh truy vấn dựa trên cấu trúc bảng của bạn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    ViewKH.DataSource = dataTable;

                    // Đặt tiêu đề cột tùy chỉnh
                    ViewKH.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                    ViewKH.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                    ViewKH.Columns["GT"].HeaderText = "Giới Tính";
                    ViewKH.Columns["Diachi"].HeaderText = "Địa Chỉ";
                    ViewKH.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    ViewKH.Columns["Sdt"].HeaderText = "Số Điện Thoại";
                    ViewKH.Columns["NgGiamHo"].HeaderText = "Người giám hộ";
                    ViewKH.Columns["CCCD"].HeaderText = "Căn cước CD";


                    ViewKH.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    // Tự động điều chỉnh kích thước cột để vừa với nội dung và form
                    ViewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Làm cho DataGridView chỉ đọc được
                    ViewKH.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void checknam_CheckedChanged(object sender, EventArgs e)
        {
            if (checknam.Checked)
            {
                checknam.Checked = true;
            }
        }
        private void checknu_CheckedChanged(object sender, EventArgs e)
        {
            if (!checknu.Checked)
            {
                checknu.Checked = false;
            }
        }

        private void ViewKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ViewKH.Rows[e.RowIndex];
                // Hiển thị dữ liệu của hàng được chọn lên các điều khiển
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDC.Text = row.Cells["Diachi"].Value.ToString();
                maskTxtSDT.Text = row.Cells["Sdt"].Value.ToString();
                txtNgGH.Text = row.Cells["NgGiamHo"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên form
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            DateTime ngaySinh = dtPNgSinh.Value;
            string gioiTinh = checknam.Checked ? "Nam" : "Nữ";
            string diaChi = txtDC.Text;
            string soDienThoai = maskTxtSDT.Text;
            string nguoiGiamHo = txtNgGH.Text;
            string cccd = txtCCCD.Text;

            // Chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = Connection.stringConnection;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateCustomers", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền các tham số vào stored procedure
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@TenKH", tenKH);
                    command.Parameters.AddWithValue("@NgSinh", ngaySinh);
                    command.Parameters.AddWithValue("@GT", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@Sdt", soDienThoai);
                    command.Parameters.AddWithValue("@NgGH", nguoiGiamHo);
                    command.Parameters.AddWithValue("@CCCD", cccd);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!");
                        // Sau khi cập nhật thành công, có thể làm mới danh sách khách hàng hoặc làm các tác vụ khác cần thiết.
                        LoadCustomerData(); // Load lại dữ liệu để cập nhật DataGridView
                        ClearInputs(); // Xóa dữ liệu trong các điều khiển để chuẩn bị cho việc nhập mới
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khách hàng thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn hàng để xóa chưa
            if (ViewKH.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                return;
            }

            // Lấy MaHS và MaNgay của hàng được chọn
            string maKH = ViewKH.SelectedRows[0].Cells["MaKH"].Value.ToString();

            string connectionString = Connection.stringConnection;
            // Thực hiện xóa từ cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DeleteCustomers", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            SearchCustomer(maKH);
        }

        private void SearchCustomer(string maKH)
        {
            string connectionString = Connection.stringConnection;
            string query = "SearchCustomer"; // Stored Procedure name

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKH", maKH);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    ViewKH.DataSource = dataTable;
                    ViewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    ViewKH.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
   
}

