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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
           
        }

        private void btnQLTC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
        }

        private void btnQLT_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBC_Click(object sender, EventArgs e)
        {

        }

        internal void OpenChildForm(PhieuKham phieuKham)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = phieuKham;
            phieuKham.TopLevel = false;
            phieuKham.FormBorderStyle = FormBorderStyle.None;
            phieuKham.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(phieuKham);
            panel_Body.Tag = phieuKham;
            phieuKham.BringToFront();
            phieuKham.Show();
        }

    }
}
