namespace CNPM_QLBH.GUI
{
    partial class QuanLiNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxChucVu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtQueQuan = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptbHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.txtTitleChucVu = new System.Windows.Forms.Label();
            this.txtTitleHoTen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.dgvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHUCVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbxGioiTinh);
            this.panel6.Controls.Add(this.cbxChucVu);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtTaiKhoan);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.dtNgaySinh);
            this.panel6.Controls.Add(this.txtQueQuan);
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.txtSDT);
            this.panel6.Controls.Add(this.txtHoTen);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(514, 460);
            this.panel6.TabIndex = 1;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.Location = new System.Drawing.Point(140, 254);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGioiTinh.Properties.Items.AddRange(new object[] {
            "Nữ ",
            "Nam"});
            this.cbxGioiTinh.Size = new System.Drawing.Size(258, 22);
            this.cbxGioiTinh.TabIndex = 33;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Location = new System.Drawing.Point(141, 86);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxChucVu.Properties.Items.AddRange(new object[] {
            "Quản Trị Viên",
            "Nhân Viên"});
            this.cbxChucVu.Size = new System.Drawing.Size(258, 22);
            this.cbxChucVu.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Quê Quán:  ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(140, 317);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(259, 22);
            this.txtTaiKhoan.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số Điện Thoại: ";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(140, 138);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Size = new System.Drawing.Size(259, 22);
            this.dtNgaySinh.TabIndex = 27;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(140, 432);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(259, 41);
            this.txtQueQuan.TabIndex = 26;
            this.txtQueQuan.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 370);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 197);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(259, 22);
            this.txtSDT.TabIndex = 24;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(259, 22);
            this.txtHoTen.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tài Khoản: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Sinh: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chức Vụ: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ Và Tên: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ptbHinhAnh);
            this.panel3.Controls.Add(this.txtTitleChucVu);
            this.panel3.Controls.Add(this.txtTitleHoTen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 167);
            this.panel3.TabIndex = 0;
            // 
            // ptbHinhAnh
            // 
            this.ptbHinhAnh.Location = new System.Drawing.Point(1, 4);
            this.ptbHinhAnh.Name = "ptbHinhAnh";
            this.ptbHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ptbHinhAnh.Properties.ZoomAccelerationFactor = 1D;
            this.ptbHinhAnh.Size = new System.Drawing.Size(193, 156);
            this.ptbHinhAnh.TabIndex = 5;
            this.ptbHinhAnh.Click += new System.EventHandler(this.ptbHinhAnh_Click);
            // 
            // txtTitleChucVu
            // 
            this.txtTitleChucVu.AutoSize = true;
            this.txtTitleChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtTitleChucVu.Location = new System.Drawing.Point(206, 83);
            this.txtTitleChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleChucVu.Name = "txtTitleChucVu";
            this.txtTitleChucVu.Size = new System.Drawing.Size(89, 17);
            this.txtTitleChucVu.TabIndex = 4;
            this.txtTitleChucVu.Text = "Quản trị viên";
            // 
            // txtTitleHoTen
            // 
            this.txtTitleHoTen.AutoSize = true;
            this.txtTitleHoTen.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtTitleHoTen.Location = new System.Drawing.Point(201, 23);
            this.txtTitleHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleHoTen.Name = "txtTitleHoTen";
            this.txtTitleHoTen.Size = new System.Drawing.Size(296, 49);
            this.txtTitleHoTen.TabIndex = 3;
            this.txtTitleHoTen.Text = "Tăng Đại Dương";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(516, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 629);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grcNhanVien);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 481);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // grcNhanVien
            // 
            this.grcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNhanVien.Location = new System.Drawing.Point(3, 18);
            this.grcNhanVien.MainView = this.dgvNhanVien;
            this.grcNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grcNhanVien.Name = "grcNhanVien";
            this.grcNhanVien.Size = new System.Drawing.Size(911, 460);
            this.grcNhanVien.TabIndex = 3;
            this.grcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNhanVien});
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvNhanVien.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvNhanVien.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvNhanVien.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.Appearance.Row.Options.UseFont = true;
            this.dgvNhanVien.Appearance.RowSeparator.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.Appearance.RowSeparator.Options.UseFont = true;
            this.dgvNhanVien.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.Appearance.SelectedRow.Options.UseFont = true;
            this.dgvNhanVien.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dgvNhanVien.ColumnPanelRowHeight = 30;
            this.dgvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TEN,
            this.GIOITINH,
            this.CHUCVU});
            this.dgvNhanVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvNhanVien.GridControl = this.grcNhanVien;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.OptionsBehavior.Editable = false;
            this.dgvNhanVien.OptionsBehavior.ReadOnly = true;
            this.dgvNhanVien.OptionsCustomization.AllowColumnMoving = false;
            this.dgvNhanVien.OptionsCustomization.AllowColumnResizing = false;
            this.dgvNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvNhanVien.OptionsView.ShowGroupPanel = false;
            this.dgvNhanVien.PaintStyleName = "UltraFlat";
            this.dgvNhanVien.RowHeight = 30;
            this.dgvNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvNhanVien_FocusedRowChanged);
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
            // 
            // TEN
            // 
            this.TEN.Caption = "Họ và Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Caption = "Giới Tính";
            this.GIOITINH.FieldName = "GIOITINH";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 2;
            // 
            // CHUCVU
            // 
            this.CHUCVU.Caption = "Chức Vụ";
            this.CHUCVU.FieldName = "CHUCVU";
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.Visible = true;
            this.CHUCVU.VisibleIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHuy);
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 553);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(917, 76);
            this.panel5.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(491, 4);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 65);
            this.btnHuy.TabIndex = 99;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(370, 4);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 65);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(7, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 65);
            this.btnThem.TabIndex = 96;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(249, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 65);
            this.btnXoa.TabIndex = 98;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(128, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 65);
            this.btnSua.TabIndex = 100;
            this.btnSua.Text = "Sửa ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(917, 72);
            this.panel4.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(137, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(429, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // QuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLiNhanVien";
            this.Size = new System.Drawing.Size(1433, 629);
            this.Load += new System.EventHandler(this.QuanLiNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhAnh.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTitleChucVu;
        private System.Windows.Forms.Label txtTitleHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl grcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNhanVien;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn CHUCVU;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
        private System.Windows.Forms.RichTextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbxChucVu;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGioiTinh;
        private DevExpress.XtraEditors.PictureEdit ptbHinhAnh;
    }
}
