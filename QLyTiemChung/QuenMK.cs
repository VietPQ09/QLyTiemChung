using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyTiemChung
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            labelKQ.Text = "";
        }

        Modify modify = new Modify();
        private void buttonLLMK_Click(object sender, EventArgs e)
        {
            string email = txtEmailDK.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí");
            }
            else
            {
                string query = "Select * from Tai_Khoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!= 0)
                {
                    labelKQ.ForeColor = Color.Blue;
                    labelKQ.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    labelKQ.ForeColor = Color.Red;
                    labelKQ.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
