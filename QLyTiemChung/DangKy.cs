using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLyTiemChung
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac) // check mat khau vaf ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();
        private void buttonDK_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text;
            string matKhau = txtMK.Text;
            string xnMK = txtXNMK.Text;
            string email = txtEmail.Text;
            if(!CheckAccount(tenTK))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản có đủ kí tự!");
                return;
            }
            if (!CheckAccount(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên mật khẩu có đủ kí tự!");
                return;
            }
            if(xnMK != matKhau)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu chính xác");
                return;
            }
            if(!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!");
                return;
            }
            if(modify.TaiKhoans("Select * from Tai_Khoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí ");
            }
            try
            {
                string query = "insert into Tai_Khoan values('"+tenTK+"', '"+matKhau+"', '"+email+"')";
                modify.Command(query);
                if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập luôn không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng kí!");
            }


            }
        }
    }
