using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyTiemChung
{
    public partial class DsachPkham : Form
    {
        public DsachPkham()
        {
            InitializeComponent();
        }

        private void DsachPkam_Load(object sender, EventArgs e)
        {
            LoadDSPhieuKhamData();
        }

        private void LoadDSPhieuKhamData()
        {
            string connectionString = Connection.stringConnection;
            string query = @"
                SELECT pk.MaPK, pk.Ngay, pk.TenBS, pk.KetLuan, kh.MaKH, kh.TenKH, kh.NgaySinh, kh.GT, kh.DiaChi, kh.SDT, kh.NgGiamHo, kh.CCCD
                FROM Phieu_Kham pk
                LEFT JOIN Khach_Hang kh ON pk.MaKH = kh.MaKH";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    ViewDSPK.DataSource = dataTable;

                    // Đặt tiêu đề cột tùy chỉnh
                    ViewDSPK.Columns["MaPK"].HeaderText = "Mã Phiếu Khám";
                    ViewDSPK.Columns["Ngay"].HeaderText = "Ngày Khám";
                    ViewDSPK.Columns["TenBS"].HeaderText = "Tên Bác Sĩ";
                    ViewDSPK.Columns["KetLuan"].HeaderText = "Kết Luận";
                    ViewDSPK.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                    ViewDSPK.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                    ViewDSPK.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    ViewDSPK.Columns["GT"].HeaderText = "Giới Tính";
                    ViewDSPK.Columns["Diachi"].HeaderText = "Địa Chỉ";
                    ViewDSPK.Columns["Sdt"].HeaderText = "Số Điện Thoại";
                    ViewDSPK.Columns["NgGiamHo"].HeaderText = "Người giám hộ";
                    ViewDSPK.Columns["CCCD"].HeaderText = "Căn cước CD";

                    ViewDSPK.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                    // Tự động điều chỉnh kích thước cột để vừa với nội dung và form
                    ViewDSPK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Làm cho DataGridView chỉ đọc được
                    ViewDSPK.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
