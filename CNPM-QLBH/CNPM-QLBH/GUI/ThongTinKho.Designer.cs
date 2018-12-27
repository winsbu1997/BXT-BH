namespace CNPM_QLBH.GUI
{
    partial class ThongTinKho
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTenMatHang = new System.Windows.Forms.RadioButton();
            this.rdGiaBan = new System.Windows.Forms.RadioButton();
            this.rdSoLuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMATHANGMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMATHANG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1626, 614);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTenMatHang);
            this.groupBox3.Controls.Add(this.rdGiaBan);
            this.groupBox3.Controls.Add(this.rdSoLuong);
            this.groupBox3.Location = new System.Drawing.Point(20, 134);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(373, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thứ tự ưu tiên";
            // 
            // rdTenMatHang
            // 
            this.rdTenMatHang.AutoSize = true;
            this.rdTenMatHang.Location = new System.Drawing.Point(24, 92);
            this.rdTenMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.rdTenMatHang.Name = "rdTenMatHang";
            this.rdTenMatHang.Size = new System.Drawing.Size(132, 25);
            this.rdTenMatHang.TabIndex = 3;
            this.rdTenMatHang.Text = "Tên mặt hàng";
            this.rdTenMatHang.UseVisualStyleBackColor = true;
            this.rdTenMatHang.CheckedChanged += new System.EventHandler(this.Load_CheckedChanged);
            // 
            // rdGiaBan
            // 
            this.rdGiaBan.AutoSize = true;
            this.rdGiaBan.Location = new System.Drawing.Point(24, 145);
            this.rdGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.rdGiaBan.Name = "rdGiaBan";
            this.rdGiaBan.Size = new System.Drawing.Size(89, 25);
            this.rdGiaBan.TabIndex = 1;
            this.rdGiaBan.Text = "Giá bán";
            this.rdGiaBan.UseVisualStyleBackColor = true;
            this.rdGiaBan.CheckedChanged += new System.EventHandler(this.Load_CheckedChanged);
            // 
            // rdSoLuong
            // 
            this.rdSoLuong.AutoSize = true;
            this.rdSoLuong.Checked = true;
            this.rdSoLuong.Location = new System.Drawing.Point(24, 39);
            this.rdSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.rdSoLuong.Name = "rdSoLuong";
            this.rdSoLuong.Size = new System.Drawing.Size(176, 25);
            this.rdSoLuong.TabIndex = 0;
            this.rdSoLuong.TabStop = true;
            this.rdSoLuong.Text = "Số lượng trong kho";
            this.rdSoLuong.UseVisualStyleBackColor = true;
            this.rdSoLuong.CheckedChanged += new System.EventHandler(this.Load_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvMATHANGMain);
            this.groupBox2.Location = new System.Drawing.Point(419, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1175, 569);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgvMATHANGMain
            // 
            this.dgvMATHANGMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMATHANGMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMATHANGMain.Location = new System.Drawing.Point(4, 26);
            this.dgvMATHANGMain.MainView = this.dgvMATHANG;
            this.dgvMATHANGMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMATHANGMain.Name = "dgvMATHANGMain";
            this.dgvMATHANGMain.Size = new System.Drawing.Size(1167, 539);
            this.dgvMATHANGMain.TabIndex = 2;
            this.dgvMATHANGMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMATHANG});
            // 
            // dgvMATHANG
            // 
            this.dgvMATHANG.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMATHANG.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMATHANG.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.Row.Options.UseFont = true;
            this.dgvMATHANG.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvMATHANG.ColumnPanelRowHeight = 30;
            this.dgvMATHANG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.DonViTinh,
            this.GiaBan,
            this.SoLuong});
            this.dgvMATHANG.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMATHANG.GridControl = this.dgvMATHANGMain;
            this.dgvMATHANG.Name = "dgvMATHANG";
            this.dgvMATHANG.OptionsBehavior.Editable = false;
            this.dgvMATHANG.OptionsBehavior.ReadOnly = true;
            this.dgvMATHANG.OptionsCustomization.AllowColumnMoving = false;
            this.dgvMATHANG.OptionsCustomization.AllowColumnResizing = false;
            this.dgvMATHANG.OptionsCustomization.AllowFilter = false;
            this.dgvMATHANG.OptionsCustomization.AllowGroup = false;
            this.dgvMATHANG.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMATHANG.OptionsFind.AllowFindPanel = false;
            this.dgvMATHANG.OptionsView.ShowGroupPanel = false;
            this.dgvMATHANG.PaintStyleName = "UltraFlat";
            this.dgvMATHANG.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 52;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên mặt hàng";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 326;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.DonViTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            this.DonViTinh.Width = 164;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 3;
            this.GiaBan.Width = 255;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 4;
            this.SoLuong.Width = 236;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(24, 49);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(324, 29);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm tên sản phẩm";
            // 
            // ThongTinKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinKho";
            this.Size = new System.Drawing.Size(1626, 614);
            this.Load += new System.EventHandler(this.ThongTinKho_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdTenMatHang;
        private System.Windows.Forms.RadioButton rdGiaBan;
        private System.Windows.Forms.RadioButton rdSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl dgvMATHANGMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMATHANG;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}
