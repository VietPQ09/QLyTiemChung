namespace QLyTiemChung
{
    partial class PhieuTP
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
            this.btnDSPT = new System.Windows.Forms.Button();
            this.btnTTPT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_PT = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDSPT
            // 
            this.btnDSPT.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDSPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSPT.Location = new System.Drawing.Point(9, 14);
            this.btnDSPT.Name = "btnDSPT";
            this.btnDSPT.Size = new System.Drawing.Size(364, 59);
            this.btnDSPT.TabIndex = 0;
            this.btnDSPT.Text = "Danh Sách Phiếu Tiêm";
            this.btnDSPT.UseVisualStyleBackColor = false;
            this.btnDSPT.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTTPT
            // 
            this.btnTTPT.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTPT.Location = new System.Drawing.Point(406, 14);
            this.btnTTPT.Name = "btnTTPT";
            this.btnTTPT.Size = new System.Drawing.Size(382, 59);
            this.btnTTPT.TabIndex = 1;
            this.btnTTPT.Text = "Thông Tin Phiếu Tiêm";
            this.btnTTPT.UseVisualStyleBackColor = false;
            this.btnTTPT.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDSPT);
            this.panel1.Controls.Add(this.btnTTPT);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 73);
            this.panel1.TabIndex = 2;
            // 
            // panel_PT
            // 
            this.panel_PT.Location = new System.Drawing.Point(12, 91);
            this.panel_PT.Name = "panel_PT";
            this.panel_PT.Size = new System.Drawing.Size(1399, 752);
            this.panel_PT.TabIndex = 3;
            // 
            // PhieuTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 855);
            this.Controls.Add(this.panel_PT);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuTP";
            this.Text = "PhieuTP";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDSPT;
        private System.Windows.Forms.Button btnTTPT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_PT;
    }
}