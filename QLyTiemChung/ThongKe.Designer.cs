namespace QLyTiemChung
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7day = new System.Windows.Forms.Button();
            this.btnLast30day = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnOKcustom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfThuoc = new System.Windows.Forms.Label();
            this.NumbeOfThuoc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.TotalRevenue = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5Medicines = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumberOfMedicines = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumberOfPT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Medicines)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(206, 15);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(178, 30);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(406, 15);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(178, 30);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThisMonth.Location = new System.Drawing.Point(1244, 19);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 3;
            this.btnThisMonth.Text = "This Month";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnToday.Location = new System.Drawing.Point(823, 19);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 4;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7day
            // 
            this.btnLast7day.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLast7day.Location = new System.Drawing.Point(964, 19);
            this.btnLast7day.Name = "btnLast7day";
            this.btnLast7day.Size = new System.Drawing.Size(120, 30);
            this.btnLast7day.TabIndex = 5;
            this.btnLast7day.Text = "Last 7 days";
            this.btnLast7day.UseVisualStyleBackColor = false;
            this.btnLast7day.Click += new System.EventHandler(this.btnLast7day_Click);
            // 
            // btnLast30day
            // 
            this.btnLast30day.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLast30day.Location = new System.Drawing.Point(1104, 19);
            this.btnLast30day.Name = "btnLast30day";
            this.btnLast30day.Size = new System.Drawing.Size(120, 30);
            this.btnLast30day.TabIndex = 6;
            this.btnLast30day.Text = "Last 30 days";
            this.btnLast30day.UseVisualStyleBackColor = false;
            this.btnLast30day.Click += new System.EventHandler(this.btnLast30day_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCustom.Location = new System.Drawing.Point(687, 18);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(120, 30);
            this.btnCustom.TabIndex = 7;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnOKcustom
            // 
            this.btnOKcustom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOKcustom.Location = new System.Drawing.Point(631, 19);
            this.btnOKcustom.Name = "btnOKcustom";
            this.btnOKcustom.Size = new System.Drawing.Size(50, 30);
            this.btnOKcustom.TabIndex = 8;
            this.btnOKcustom.Text = "OK";
            this.btnOKcustom.UseVisualStyleBackColor = false;
            this.btnOKcustom.Click += new System.EventHandler(this.btnOKcustom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumberOfThuoc);
            this.panel1.Controls.Add(this.NumbeOfThuoc);
            this.panel1.Location = new System.Drawing.Point(19, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 100);
            this.panel1.TabIndex = 9;
            // 
            // lblNumberOfThuoc
            // 
            this.lblNumberOfThuoc.AutoSize = true;
            this.lblNumberOfThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfThuoc.Location = new System.Drawing.Point(91, 49);
            this.lblNumberOfThuoc.Name = "lblNumberOfThuoc";
            this.lblNumberOfThuoc.Size = new System.Drawing.Size(117, 36);
            this.lblNumberOfThuoc.TabIndex = 1;
            this.lblNumberOfThuoc.Text = "100000";
            // 
            // NumbeOfThuoc
            // 
            this.NumbeOfThuoc.AutoSize = true;
            this.NumbeOfThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumbeOfThuoc.Location = new System.Drawing.Point(78, 0);
            this.NumbeOfThuoc.Name = "NumbeOfThuoc";
            this.NumbeOfThuoc.Size = new System.Drawing.Size(168, 25);
            this.NumbeOfThuoc.TabIndex = 0;
            this.NumbeOfThuoc.Text = "Number Of Thuoc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.TotalRevenue);
            this.panel2.Location = new System.Drawing.Point(517, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 100);
            this.panel2.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(108, 49);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(117, 36);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.AutoSize = true;
            this.TotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenue.Location = new System.Drawing.Point(96, 0);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(139, 25);
            this.TotalRevenue.TabIndex = 0;
            this.TotalRevenue.Text = "Total Revenue";
            // 
            // chartGrossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(12, 168);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(838, 467);
            this.chartGrossRevenue.TabIndex = 11;
            this.chartGrossRevenue.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            title1.Name = "Title1";
            title1.Text = "Doanh Thu";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // chartTop5Medicines
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTop5Medicines.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTop5Medicines.Legends.Add(legend2);
            this.chartTop5Medicines.Location = new System.Drawing.Point(863, 183);
            this.chartTop5Medicines.Name = "chartTop5Medicines";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTop5Medicines.Series.Add(series2);
            this.chartTop5Medicines.Size = new System.Drawing.Size(489, 660);
            this.chartTop5Medicines.TabIndex = 12;
            this.chartTop5Medicines.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top 5 Thuốc";
            this.chartTop5Medicines.Titles.Add(title2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNumberOfMedicines);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblNumberOfPT);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblNumberOfKH);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 641);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 202);
            this.panel3.TabIndex = 10;
            // 
            // lblNumberOfMedicines
            // 
            this.lblNumberOfMedicines.AutoSize = true;
            this.lblNumberOfMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMedicines.Location = new System.Drawing.Point(616, 145);
            this.lblNumberOfMedicines.Name = "lblNumberOfMedicines";
            this.lblNumberOfMedicines.Size = new System.Drawing.Size(117, 36);
            this.lblNumberOfMedicines.TabIndex = 7;
            this.lblNumberOfMedicines.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Lượng Thuốc";
            // 
            // lblNumberOfPT
            // 
            this.lblNumberOfPT.AutoSize = true;
            this.lblNumberOfPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPT.Location = new System.Drawing.Point(366, 145);
            this.lblNumberOfPT.Name = "lblNumberOfPT";
            this.lblNumberOfPT.Size = new System.Drawing.Size(117, 36);
            this.lblNumberOfPT.TabIndex = 4;
            this.lblNumberOfPT.Text = "100000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Lượng Phiếu Tiêm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Counter";
            // 
            // lblNumberOfKH
            // 
            this.lblNumberOfKH.AutoSize = true;
            this.lblNumberOfKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfKH.Location = new System.Drawing.Point(91, 145);
            this.lblNumberOfKH.Name = "lblNumberOfKH";
            this.lblNumberOfKH.Size = new System.Drawing.Size(117, 36);
            this.lblNumberOfKH.TabIndex = 1;
            this.lblNumberOfKH.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Khách hàng";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 855);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartTop5Medicines);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOKcustom);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnLast30day);
            this.Controls.Add(this.btnLast7day);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Medicines)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7day;
        private System.Windows.Forms.Button btnLast30day;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnOKcustom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NumbeOfThuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalRevenue;
        private System.Windows.Forms.Label lblNumberOfThuoc;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Medicines;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfMedicines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumberOfPT;
        private System.Windows.Forms.Label label5;
    }
}