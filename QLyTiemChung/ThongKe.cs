using QLyTiemChung;
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
    public partial class ThongKe : Form
    {
        private Dashboard model;
        public ThongKe()
        {
            InitializeComponent();
            // Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7day.Select();

            model = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lblNumberOfThuoc.Text = model.NumThuoc.ToString();
                lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();

                lblNumberOfKH.Text = model.NumCustomers.ToString();
                lblNumberOfPT.Text = model.NumPhieuTiem.ToString();
                lblNumberOfMedicines.Text = model.NumThuoc.ToString();

                Console.WriteLine("Number of records in GrossRevenueList: " + model.GrossRevenueList.Count);
                foreach (var record in model.GrossRevenueList)
                {
                    Console.WriteLine("Date: " + record.Date + ", TotalAmount: " + record.TotalAmount);
                }

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTop5Medicines.DataSource = model.TopThuocList;
                chartTop5Medicines.Series[0].XValueMember = "Key";
                chartTop5Medicines.Series[0].YValueMembers = "Value";
                chartTop5Medicines.DataBind();

                Console.WriteLine("Loaded view: )");
            }
            else
                Console.WriteLine("View not loaded, same query");
        }


        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOKcustom.Visible = false;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30day_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOKcustom.Visible = true;
        }

        private void btnOKcustom_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}
