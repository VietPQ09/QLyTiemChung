namespace QLyTiemChung
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDX = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnQLT = new System.Windows.Forms.Button();
            this.btnQLTC = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDX
            // 
            this.buttonDX.AutoSize = true;
            this.buttonDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDX.Location = new System.Drawing.Point(2, 799);
            this.buttonDX.Name = "buttonDX";
            this.buttonDX.Size = new System.Drawing.Size(135, 39);
            this.buttonDX.TabIndex = 10;
            this.buttonDX.Text = "Đăng Xuất";
            this.buttonDX.UseVisualStyleBackColor = true;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.White;
            this.panel_left.Controls.Add(this.button5);
            this.panel_left.Controls.Add(this.btnBC);
            this.panel_left.Controls.Add(this.btnQLT);
            this.panel_left.Controls.Add(this.btnQLTC);
            this.panel_left.Controls.Add(this.btnNV);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(345, 1021);
            this.panel_left.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 954);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(345, 67);
            this.button5.TabIndex = 5;
            this.button5.Text = "         Log out";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBC.Location = new System.Drawing.Point(0, 417);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(345, 67);
            this.btnBC.TabIndex = 4;
            this.btnBC.Text = "           Báo Cáo - Thống kế";
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnQLT
            // 
            this.btnQLT.BackColor = System.Drawing.Color.LimeGreen;
            this.btnQLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLT.Location = new System.Drawing.Point(0, 348);
            this.btnQLT.Name = "btnQLT";
            this.btnQLT.Size = new System.Drawing.Size(345, 69);
            this.btnQLT.TabIndex = 3;
            this.btnQLT.Text = "         Quản Lý Thuốc";
            this.btnQLT.UseVisualStyleBackColor = false;
            this.btnQLT.Click += new System.EventHandler(this.btnQLT_Click);
            // 
            // btnQLTC
            // 
            this.btnQLTC.BackColor = System.Drawing.Color.LimeGreen;
            this.btnQLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTC.Location = new System.Drawing.Point(0, 282);
            this.btnQLTC.Name = "btnQLTC";
            this.btnQLTC.Size = new System.Drawing.Size(345, 66);
            this.btnQLTC.TabIndex = 2;
            this.btnQLTC.Text = "          Quản Lý Tiêm Chủng";
            this.btnQLTC.UseVisualStyleBackColor = false;
            this.btnQLTC.Click += new System.EventHandler(this.btnQLTC_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNV.Location = new System.Drawing.Point(0, 213);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(345, 69);
            this.btnNV.TabIndex = 1;
            this.btnNV.Text = "      Quản Lý Tài Khoản";
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(345, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 67);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "  Hệ Thống Quản Lý Tiêm Chủng";
            // 
            // panel_Body
            // 
            this.panel_Body.AutoSize = true;
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(345, 67);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1633, 954);
            this.panel_Body.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1021);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.buttonDX);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDX;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnQLT;
        private System.Windows.Forms.Button btnQLTC;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}