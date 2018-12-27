namespace CNPM_QLBH.GUI
{
    partial class NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMatHang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCHITIETNHAP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvCHITIETNHAPMain = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupChiTietNhap = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupPhieuNhap = new System.Windows.Forms.GroupBox();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.txtChiPhi = new System.Windows.Forms.Label();
            this.cbxNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.dateNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLuuPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAPMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupChiTietNhap.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupPhieuNhap.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnInHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 213);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(383, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 54);
            this.btnLuu.TabIndex = 107;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(578, 6);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(170, 54);
            this.btnHuy.TabIndex = 106;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(170, 54);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(191, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 54);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(780, 4);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(284, 54);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtTongTien);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtDonGia);
            this.panel5.Controls.Add(this.txtDonViTinh);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.cbxMatHang);
            this.panel5.Controls.Add(this.txtSoLuong);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 26);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1068, 187);
            this.panel5.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(205, 145);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(20, 22);
            this.txtTongTien.TabIndex = 45;
            this.txtTongTien.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Thành tiền :";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(708, 81);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(300, 29);
            this.txtDonGia.TabIndex = 43;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.AutoSize = true;
            this.txtDonViTinh.Location = new System.Drawing.Point(704, 25);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(43, 21);
            this.txtDonViTinh.TabIndex = 42;
            this.txtDonViTinh.Text = "Suất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "Đơn vị tính :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Đơn giá : ";
            // 
            // cbxMatHang
            // 
            this.cbxMatHang.Location = new System.Drawing.Point(209, 20);
            this.cbxMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMatHang.Name = "cbxMatHang";
            this.cbxMatHang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxMatHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxMatHang.Properties.Appearance.Options.UseFont = true;
            this.cbxMatHang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxMatHang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxMatHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxMatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMatHang.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxMatHang.Properties.ShowHeader = false;
            this.cbxMatHang.Size = new System.Drawing.Size(311, 28);
            this.cbxMatHang.TabIndex = 38;
            this.cbxMatHang.EditValueChanged += new System.EventHandler(this.cbxMatHang_EditValueChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(212, 82);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(67, 29);
            this.txtSoLuong.TabIndex = 37;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mặt hàng : ";
            // 
            // dgvCHITIETNHAP
            // 
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvCHITIETNHAP.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvCHITIETNHAP.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvCHITIETNHAP.Appearance.Row.Options.UseFont = true;
            this.dgvCHITIETNHAP.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvCHITIETNHAP.ColumnPanelRowHeight = 30;
            this.dgvCHITIETNHAP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MatHang,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvCHITIETNHAP.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvCHITIETNHAP.GridControl = this.dgvCHITIETNHAPMain;
            this.dgvCHITIETNHAP.Name = "dgvCHITIETNHAP";
            this.dgvCHITIETNHAP.OptionsBehavior.Editable = false;
            this.dgvCHITIETNHAP.OptionsBehavior.ReadOnly = true;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowColumnMoving = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowColumnResizing = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowFilter = false;
            this.dgvCHITIETNHAP.OptionsCustomization.AllowGroup = false;
            this.dgvCHITIETNHAP.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvCHITIETNHAP.OptionsFind.AllowFindPanel = false;
            this.dgvCHITIETNHAP.OptionsView.ShowGroupPanel = false;
            this.dgvCHITIETNHAP.PaintStyleName = "UltraFlat";
            this.dgvCHITIETNHAP.RowHeight = 30;
            this.dgvCHITIETNHAP.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvCHITIETNHAP_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 50;
            // 
            // MatHang
            // 
            this.MatHang.Caption = "Mặt hàng";
            this.MatHang.FieldName = "MatHang";
            this.MatHang.Name = "MatHang";
            this.MatHang.Visible = true;
            this.MatHang.VisibleIndex = 1;
            this.MatHang.Width = 247;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 124;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 124;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 154;
            // 
            // dgvCHITIETNHAPMain
            // 
            this.dgvCHITIETNHAPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCHITIETNHAPMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCHITIETNHAPMain.Location = new System.Drawing.Point(4, 26);
            this.dgvCHITIETNHAPMain.MainView = this.dgvCHITIETNHAP;
            this.dgvCHITIETNHAPMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCHITIETNHAPMain.Name = "dgvCHITIETNHAPMain";
            this.dgvCHITIETNHAPMain.Size = new System.Drawing.Size(1060, 284);
            this.dgvCHITIETNHAPMain.TabIndex = 2;
            this.dgvCHITIETNHAPMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCHITIETNHAP});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupChiTietNhap);
            this.panel1.Controls.Add(this.groupPhieuNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 639);
            this.panel1.TabIndex = 2;
            // 
            // groupChiTietNhap
            // 
            this.groupChiTietNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupChiTietNhap.Controls.Add(this.groupBox4);
            this.groupChiTietNhap.Controls.Add(this.panel2);
            this.groupChiTietNhap.Controls.Add(this.panel5);
            this.groupChiTietNhap.Location = new System.Drawing.Point(633, 20);
            this.groupChiTietNhap.Margin = new System.Windows.Forms.Padding(4);
            this.groupChiTietNhap.Name = "groupChiTietNhap";
            this.groupChiTietNhap.Padding = new System.Windows.Forms.Padding(4);
            this.groupChiTietNhap.Size = new System.Drawing.Size(1076, 596);
            this.groupChiTietNhap.TabIndex = 14;
            this.groupChiTietNhap.TabStop = false;
            this.groupChiTietNhap.Text = "Thông tin phiếu nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCHITIETNHAPMain);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(4, 278);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1068, 314);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết nhập";
            // 
            // groupPhieuNhap
            // 
            this.groupPhieuNhap.Controls.Add(this.panelThongTin);
            this.groupPhieuNhap.Controls.Add(this.panel3);
            this.groupPhieuNhap.Location = new System.Drawing.Point(31, 20);
            this.groupPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.groupPhieuNhap.Name = "groupPhieuNhap";
            this.groupPhieuNhap.Padding = new System.Windows.Forms.Padding(4);
            this.groupPhieuNhap.Size = new System.Drawing.Size(595, 287);
            this.groupPhieuNhap.TabIndex = 2;
            this.groupPhieuNhap.TabStop = false;
            this.groupPhieuNhap.Text = "Thông tin phiếu nhập";
            this.groupPhieuNhap.UseCompatibleTextRendering = true;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThongTin.Controls.Add(this.txtChiPhi);
            this.panelThongTin.Controls.Add(this.cbxNhanVien);
            this.panelThongTin.Controls.Add(this.dateNgayNhap);
            this.panelThongTin.Controls.Add(this.label6);
            this.panelThongTin.Controls.Add(this.label5);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(4, 26);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(587, 188);
            this.panelThongTin.TabIndex = 2;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.AutoSize = true;
            this.txtChiPhi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiPhi.Location = new System.Drawing.Point(168, 142);
            this.txtChiPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(20, 22);
            this.txtChiPhi.TabIndex = 4;
            this.txtChiPhi.Text = "0";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Location = new System.Drawing.Point(168, 76);
            this.cbxNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cbxNhanVien.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhanVien.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNhanVien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNhanVien.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhanVien.Properties.ShowHeader = false;
            this.cbxNhanVien.Size = new System.Drawing.Size(329, 28);
            this.cbxNhanVien.TabIndex = 3;
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.EditValue = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(168, 16);
            this.dateNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayNhap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateNgayNhap.Properties.Appearance.Options.UseFont = true;
            this.dateNgayNhap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNgayNhap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateNgayNhap.Size = new System.Drawing.Size(209, 28);
            this.dateNgayNhap.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng chi phí :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên nhập :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuuPhieuNhap);
            this.panel3.Controls.Add(this.btnLapPhieuNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 69);
            this.panel3.TabIndex = 1;
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuNhap.Appearance.Options.UseFont = true;
            this.btnLuuPhieuNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLuuPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuNhap.Image")));
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(306, 7);
            this.btnLuuPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(277, 54);
            this.btnLuuPhieuNhap.TabIndex = 7;
            this.btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // btnLapPhieuNhap
            // 
            this.btnLapPhieuNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuNhap.Appearance.Options.UseFont = true;
            this.btnLapPhieuNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLapPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuNhap.Image")));
            this.btnLapPhieuNhap.Location = new System.Drawing.Point(9, 7);
            this.btnLapPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            this.btnLapPhieuNhap.Size = new System.Drawing.Size(274, 54);
            this.btnLapPhieuNhap.TabIndex = 5;
            this.btnLapPhieuNhap.Text = "Lập phiếu nhập";
            this.btnLapPhieuNhap.Click += new System.EventHandler(this.btnLapPhieuNhap_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NhapHang";
            this.Size = new System.Drawing.Size(1732, 639);
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETNHAPMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupChiTietNhap.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupPhieuNhap.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label txtDonViTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit cbxMatHang;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn MatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCHITIETNHAP;
        private DevExpress.XtraGrid.GridControl dgvCHITIETNHAPMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupChiTietNhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupPhieuNhap;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label txtChiPhi;
        private DevExpress.XtraEditors.LookUpEdit cbxNhanVien;
        private DevExpress.XtraEditors.DateEdit dateNgayNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnLuuPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}
