namespace QLyTiemChung
{
    partial class PhieuKham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDspk = new System.Windows.Forms.Button();
            this.panelPK = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnDspk);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 72);
            this.panel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.CadetBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(415, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(306, 56);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm phiếu khám";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDspk
            // 
            this.btnDspk.BackColor = System.Drawing.Color.Chocolate;
            this.btnDspk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDspk.Location = new System.Drawing.Point(3, 12);
            this.btnDspk.Name = "btnDspk";
            this.btnDspk.Size = new System.Drawing.Size(366, 57);
            this.btnDspk.TabIndex = 0;
            this.btnDspk.Text = "Danh sách phiếu khám ";
            this.btnDspk.UseVisualStyleBackColor = false;
            this.btnDspk.Click += new System.EventHandler(this.btnDspk_Click);
            // 
            // panelPK
            // 
            this.panelPK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPK.Location = new System.Drawing.Point(-2, 78);
            this.panelPK.Name = "panelPK";
            this.panelPK.Size = new System.Drawing.Size(1431, 765);
            this.panelPK.TabIndex = 2;
            // 
            // PhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 855);
            this.Controls.Add(this.panelPK);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuKham";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDspk;
        private System.Windows.Forms.Panel panelPK;
    }
}