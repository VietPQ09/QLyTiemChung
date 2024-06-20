using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyTiemChung
{
    public partial class PhieuKham : Form
    {
        SqlConnection conn = Connection.GetSqlConnection();
        public PhieuKham()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPK.Controls.Add(childForm);
            panelPK.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.FormClosed += OnChildFormClosed;
        }

        private void OnChildFormClosed(object sender, FormClosedEventArgs e)
        {
            btnDspk.Show();
            btnThem.Show();
        }

        private void btnDspk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DsachPkham());
            btnDspk.Hide();
            btnThem.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemPhieuKham());
            btnDspk.Hide();
            btnThem.Hide();
        }
    }
}
