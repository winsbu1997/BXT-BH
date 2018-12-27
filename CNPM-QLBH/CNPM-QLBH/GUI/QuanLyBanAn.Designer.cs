namespace CNPM_QLBH.GUI
{
    partial class QuanLyBanAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBanAn));
            this.VITRI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHUVUCBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvBANAN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOCHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvBANANMain = new DevExpress.XtraGrid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxKhuVucBan = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCho = new System.Windows.Forms.TextBox();
            this.txtViTri = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBANAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBANANMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxKhuVucBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // VITRI
            // 
            this.VITRI.AppearanceCell.Options.UseTextOptions = true;
            this.VITRI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.VITRI.Caption = "Vị trí";
            this.VITRI.FieldName = "VITRI";
            this.VITRI.Name = "VITRI";
            this.VITRI.Visible = true;
            this.VITRI.VisibleIndex = 4;
            this.VITRI.Width = 342;
            // 
            // KHUVUCBAN
            // 
            this.KHUVUCBAN.Caption = "Khu vực bán";
            this.KHUVUCBAN.FieldName = "KHUVUCBAN";
            this.KHUVUCBAN.Name = "KHUVUCBAN";
            this.KHUVUCBAN.Visible = true;
            this.KHUVUCBAN.VisibleIndex = 2;
            this.KHUVUCBAN.Width = 224;
            // 
            // TEN
            // 
            this.TEN.AppearanceCell.Options.UseTextOptions = true;
            this.TEN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TEN.Caption = "Tên bàn ăn";
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 1;
            this.TEN.Width = 269;
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
            this.STT.Width = 63;
            // 
            // dgvBANAN
            // 
            this.dgvBANAN.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvBANAN.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvBANAN.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvBANAN.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvBANAN.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvBANAN.Appearance.Row.Options.UseFont = true;
            this.dgvBANAN.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvBANAN.ColumnPanelRowHeight = 30;
            this.dgvBANAN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TEN,
            this.KHUVUCBAN,
            this.SOCHO,
            this.VITRI});
            this.dgvBANAN.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvBANAN.GridControl = this.dgvBANANMain;
            this.dgvBANAN.Name = "dgvBANAN";
            this.dgvBANAN.OptionsBehavior.Editable = false;
            this.dgvBANAN.OptionsBehavior.ReadOnly = true;
            this.dgvBANAN.OptionsCustomization.AllowColumnMoving = false;
            this.dgvBANAN.OptionsCustomization.AllowColumnResizing = false;
            this.dgvBANAN.OptionsCustomization.AllowFilter = false;
            this.dgvBANAN.OptionsCustomization.AllowGroup = false;
            this.dgvBANAN.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvBANAN.OptionsFind.AllowFindPanel = false;
            this.dgvBANAN.OptionsView.ShowGroupPanel = false;
            this.dgvBANAN.PaintStyleName = "UltraFlat";
            this.dgvBANAN.RowHeight = 30;
            this.dgvBANAN.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvBANAN_FocusedRowChanged);
            // 
            // SOCHO
            // 
            this.SOCHO.AppearanceCell.Options.UseTextOptions = true;
            this.SOCHO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SOCHO.Caption = "Số chỗ";
            this.SOCHO.FieldName = "SOCHO";
            this.SOCHO.Name = "SOCHO";
            this.SOCHO.Visible = true;
            this.SOCHO.VisibleIndex = 3;
            this.SOCHO.Width = 135;
            // 
            // dgvBANANMain
            // 
            this.dgvBANANMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBANANMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBANANMain.Location = new System.Drawing.Point(4, 26);
            this.dgvBANANMain.MainView = this.dgvBANAN;
            this.dgvBANANMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBANANMain.Name = "dgvBANANMain";
            this.dgvBANANMain.Size = new System.Drawing.Size(810, 493);
            this.dgvBANANMain.TabIndex = 1;
            this.dgvBANANMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBANAN});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvBANANMain);
            this.groupBox1.Location = new System.Drawing.Point(35, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(818, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bàn ăn";
            // 
            // cbxKhuVucBan
            // 
            this.cbxKhuVucBan.Location = new System.Drawing.Point(192, 37);
            this.cbxKhuVucBan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxKhuVucBan.Name = "cbxKhuVucBan";
            this.cbxKhuVucBan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxKhuVucBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxKhuVucBan.Properties.Appearance.Options.UseFont = true;
            this.cbxKhuVucBan.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxKhuVucBan.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxKhuVucBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxKhuVucBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxKhuVucBan.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxKhuVucBan.Properties.ShowHeader = false;
            this.cbxKhuVucBan.Size = new System.Drawing.Size(311, 28);
            this.cbxKhuVucBan.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khu vực bàn:";
            // 
            // txtSoCho
            // 
            this.txtSoCho.Location = new System.Drawing.Point(192, 155);
            this.txtSoCho.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoCho.Name = "txtSoCho";
            this.txtSoCho.Size = new System.Drawing.Size(116, 29);
            this.txtSoCho.TabIndex = 2;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(192, 213);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtViTri.Properties.Appearance.Options.UseFont = true;
            this.txtViTri.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtViTri.Size = new System.Drawing.Size(536, 84);
            this.txtViTri.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vị trí :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(228, 31);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(493, 29);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm bàn ăn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số chỗ :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(192, 97);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(455, 29);
            this.txtTenBan.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbxKhuVucBan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoCho);
            this.groupBox2.Controls.Add(this.txtViTri);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenBan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(885, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(768, 313);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết bàn ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1678, 628);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1678, 628);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(885, 400);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 215);
            this.panel3.TabIndex = 36;
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(311, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 76);
            this.btnSua.TabIndex = 100;
            this.btnSua.Text = "Sửa ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(454, 136);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 76);
            this.btnHuy.TabIndex = 99;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(59, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 76);
            this.btnThem.TabIndex = 96;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(561, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 76);
            this.btnXoa.TabIndex = 98;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(183, 136);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 76);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // QuanLyBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyBanAn";
            this.Size = new System.Drawing.Size(1678, 628);
            this.Load += new System.EventHandler(this.QuanLyBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBANAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBANANMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxKhuVucBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn VITRI;
        private DevExpress.XtraGrid.Columns.GridColumn KHUVUCBAN;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBANAN;
        private DevExpress.XtraGrid.Columns.GridColumn SOCHO;
        private DevExpress.XtraGrid.GridControl dgvBANANMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit cbxKhuVucBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoCho;
        private DevExpress.XtraEditors.MemoEdit txtViTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}
