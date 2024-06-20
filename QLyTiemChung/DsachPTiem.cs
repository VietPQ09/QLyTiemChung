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

namespace QLyTiemChung
{
    public partial class DsachPTiem : Form
    {
        public DsachPTiem()
        {
            InitializeComponent();
        }

        private void DsachPTiem_Load(object sender, EventArgs e)
        {
            LoadDSPhieuTiemData();
        }

        private void LoadDSPhieuTiemData()
        {
            string connectionString = Connection.stringConnection;
            string query = @"select  pt.MaPhieu, pt.NgayPhieu, pt.MaNVT, kh.MaKH, kh.TenKH, kh.GT, kh.NgaySinh, kh.DiaChi, kh.SDT, kh.CCCD
                            from Khach_Hang kh
                            left join Phieu_Kham ph on kh.MaKH = ph.MaKH
                            left join Phieu_Tiem_Phong pt on ph.MaPK = pt.MaPK";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    ViewDSPT.DataSource = dt;

                    ViewDSPT.Columns["MaPhieu"].HeaderText = "Mã phiếu";
                    ViewDSPT.Columns["NgayPhieu"].HeaderText = "Ngày lập phiếu";
                    ViewDSPT.Columns["MaNVT"].HeaderText = "Mã nhân viên tiêm";
                    ViewDSPT.Columns["MaKH"].HeaderText = "Mã khách hàng";
                    ViewDSPT.Columns["TenKH"].HeaderText = "Tên khách hàng";
                    ViewDSPT.Columns["GT"].HeaderText = "Giới tính";
                    ViewDSPT.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                    ViewDSPT.Columns["DiaChi"].HeaderText = "Địa chỉ";
                    ViewDSPT.Columns["Sdt"].HeaderText = "Số điện thoại";
                    ViewDSPT.Columns["CCCD"].HeaderText = "CCCD";

                    ViewDSPT.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    ViewDSPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    ViewDSPT.ReadOnly = true;
                }
                catch(Exception ex)
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
