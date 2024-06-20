using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyTiemChung
{
    public partial class ThemPhieuKham : Form
    {

        SqlConnection conn = Connection.GetSqlConnection();
        private DataTable dataTable;
        public ThemPhieuKham()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("MaPK", typeof(string));
            dataTable.Columns.Add("Ngay", typeof(DateTime));
            dataTable.Columns.Add("TenBS", typeof(string));
            dataTable.Columns.Add("MaKH", typeof(string));
            dataTable.Columns.Add("KetLuan", typeof(string));

            ViewTPK.DataSource = dataTable;
            ViewTPK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewTPK.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPK.Text;
            DateTime ngay = dtpNgKham.Value;
            string tenBS = txtTenBS.Text;
            string maKH = txtmKH.Text;
            string ketluan = checkCo.Checked ? "được tiêm" : "không được tiêm";

            string connectionString = Connection.stringConnection;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand checkKHCommand = new SqlCommand("SELECT COUNT(*) FROM Khach_Hang WHERE MaKH = @MaKH", connection);
                    checkKHCommand.Parameters.AddWithValue("@MaKH", maKH);
                    int khExists = (int)checkKHCommand.ExecuteScalar();

                    if (khExists == 0)
                    {
                        MessageBox.Show("Mã Khách Hàng không tồn tại. Vui lòng kiểm tra lại.");
                        return;
                    }


                    SqlCommand command = new SqlCommand("InsertPhieuKham", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền các tham số vào stored procedure
                    command.Parameters.AddWithValue("@MaPK", maPK);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@TenBS", tenBS);
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@KetLuan", ketluan);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm phiếu khám thành công!");

                        DataRow newRow = dataTable.NewRow();
                        newRow["MaPK"] = maPK;
                        newRow["Ngay"] = ngay;
                        newRow["TenBS"] = tenBS;
                        newRow["MaKH"] = maKH;
                        newRow["KetLuan"] = ketluan;
                        dataTable.Rows.Add(newRow);
                        ClearInputs();

                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu khám thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void checkCo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCo.Checked)
            {
                checkCo.Checked = true;
            }
        }

        private void checkKo_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkKo.Checked) 
            {
                checkKo.Checked = false;
            }
        }

        private void ClearInputs()
        {
            txtMaPK.Text = "";
            dtpNgKham.Value = DateTime.Now;
            txtTenBS.Text = "";
            txtmKH.Text = "";
            checkCo.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPK.Text;
            DateTime ngay = dtpNgKham.Value;
            string tenBS = txtTenBS.Text;
            string maKH = txtmKH.Text;
            string ketluan = checkCo.Checked ? "Được tiêm" : "Không được tiêm";

            string connectionString = Connection.stringConnection;
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdatePhieuKham", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaPK", maPK);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    command.Parameters.AddWithValue("@TenBS", tenBS);
                    command.Parameters.AddWithValue("@MaKH", maKH);
                    command.Parameters.AddWithValue("@KetLuan", ketluan);

                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Cập nhật phiếu khám thành công!");
                        LoadPhieuKham();
                        ClearInputs();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu khám thất bại!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void LoadPhieuKham()
        {
            string connectionString = Connection.stringConnection;
            string query = "select * from Phieu_Kham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    ViewTPK.DataSource = dataTable;

                    ViewTPK.Columns["MaPK"].HeaderText = "Mã phiếu khám";
                    ViewTPK.Columns["Ngay"].HeaderText = "Ngày khám";
                    ViewTPK.Columns["TenBS"].HeaderText = "Tên bác sĩ";
                    ViewTPK.Columns["MaKH"].HeaderText = "Mã khách hàng";
                    ViewTPK.Columns["KetLuan"].HeaderText = "Kết luận";

                    ViewTPK.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    ViewTPK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    ViewTPK.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPK = txtMaPK.Text;
            if(string.IsNullOrEmpty(maPK))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu khám để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = Connection.stringConnection;

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DeletePhieuKham", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPK", maPK);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa phiếu khám thành công!");

                        // Xóa dòng từ DataTable
                        DataRow[] rows = dataTable.Select($"MaPK = '{maPK}'");
                        foreach (DataRow row in rows)
                        {
                            dataTable.Rows.Remove(row);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu khám thất bại hoặc mã phiếu khám không tồn tại.");
                    }
                }
            }
       
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
