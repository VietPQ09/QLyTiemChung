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
    public partial class PhieuTP : Form
    {
        public PhieuTP()
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
            panel_PT.Controls.Add(childForm);
            panel_PT.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.FormClosed += OnChildFormClosed;
        }

        private void OnChildFormClosed(object sender, FormClosedEventArgs e)
        {
            btnDSPT.Show();
            btnTTPT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DsachPTiem());
            btnDSPT.Hide();
            btnTTPT.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TtinPTiem());
            btnDSPT.Hide();
            btnTTPT.Hide();
        }
    }
}
