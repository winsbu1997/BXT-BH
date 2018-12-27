namespace CNPM_QLBH.GUI
{
    partial class ucBanAn
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
            this.btnBanAn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBanAn
            // 
            this.btnBanAn.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanAn.Appearance.Options.UseFont = true;
            this.btnBanAn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBanAn.Image = global::CNPM_QLBH.Properties.Resources.tray;
            this.btnBanAn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBanAn.ImageToTextIndent = 12;
            this.btnBanAn.Location = new System.Drawing.Point(0, 0);
            this.btnBanAn.Name = "btnBanAn";
            this.btnBanAn.Size = new System.Drawing.Size(95, 77);
            this.btnBanAn.TabIndex = 0;
            this.btnBanAn.Text = "Bàn 1";
            // 
            // ucBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBanAn);
            this.Name = "ucBanAn";
            this.Size = new System.Drawing.Size(95, 77);
            this.Load += new System.EventHandler(this.ucBanAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBanAn;
    }
}
