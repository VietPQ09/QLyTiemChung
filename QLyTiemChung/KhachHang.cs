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
    public partial class KhachHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=VIETPHAM\SQLEXPRESS;Initial Catalog=VaccinationSys;Integrated Security=True");
        public KhachHang()
        {
            InitializeComponent();
        }

      
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            PhieuKham phieuKham = new PhieuKham();
            Form1 parentFrom = this.ParentForm as Form1;
            parentFrom.OpenChildForm(phieuKham);
        }

    
        }
    
}
