namespace CNPM_QLBH.GUI
{
    partial class ucMatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGiaBan = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.Label();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ptbAnh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 107);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.txtTenMatHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(102, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 105);
            this.panel2.TabIndex = 5;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(11, 59);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(77, 29);
            this.txtGiaBan.TabIndex = 6;
            this.txtGiaBan.Text = "25000 vnđ";
            this.txtGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(5, 22);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(94, 24);
            this.txtTenMatHang.TabIndex = 5;
            this.txtTenMatHang.Text = "BÁNH TRÁNG TRỘN";
            this.txtTenMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbAnh
            // 
            this.ptbAnh.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnh.BackgroundImage = global::CNPM_QLBH.Properties.Resources.download;
            this.ptbAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAnh.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAnh.Location = new System.Drawing.Point(0, 0);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(102, 105);
            this.ptbAnh.TabIndex = 0;
            this.ptbAnh.TabStop = false;
            // 
            // ucMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucMatHang";
            this.Size = new System.Drawing.Size(207, 107);
            this.Load += new System.EventHandler(this.ucMatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtGiaBan;
        private System.Windows.Forms.Label txtTenMatHang;
        private System.Windows.Forms.PictureBox ptbAnh;
    }
}
