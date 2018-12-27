namespace CNPM_QLBH.GUI
{
    partial class ThongKeMonAn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMatHangMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 588);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartThongKe);
            this.groupBox2.Location = new System.Drawing.Point(24, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(585, 417);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê lượng hàng đã bán";
            // 
            // chartThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(5, 27);
            this.chartThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series1.YValuesPerPoint = 2;
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(575, 385);
            this.chartThongKe.TabIndex = 0;
            this.chartThongKe.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvMatHangMain);
            this.groupBox3.Location = new System.Drawing.Point(637, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1002, 549);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết bán hàng";
            // 
            // dgvMatHangMain
            // 
            this.dgvMatHangMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHangMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatHangMain.Location = new System.Drawing.Point(4, 26);
            this.dgvMatHangMain.MainView = this.dgvMatHang;
            this.dgvMatHangMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatHangMain.Name = "dgvMatHangMain";
            this.dgvMatHangMain.Size = new System.Drawing.Size(994, 519);
            this.dgvMatHangMain.TabIndex = 3;
            this.dgvMatHangMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMatHang});
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMatHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvMatHang.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMatHang.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMatHang.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMatHang.Appearance.Row.Options.UseFont = true;
            this.dgvMatHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvMatHang.ColumnPanelRowHeight = 30;
            this.dgvMatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvMatHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMatHang.GridControl = this.dgvMatHangMain;
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.OptionsBehavior.Editable = false;
            this.dgvMatHang.OptionsBehavior.ReadOnly = true;
            this.dgvMatHang.OptionsCustomization.AllowColumnMoving = false;
            this.dgvMatHang.OptionsCustomization.AllowColumnResizing = false;
            this.dgvMatHang.OptionsCustomization.AllowFilter = false;
            this.dgvMatHang.OptionsCustomization.AllowGroup = false;
            this.dgvMatHang.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMatHang.OptionsFind.AllowFindPanel = false;
            this.dgvMatHang.OptionsView.ShowGroupPanel = false;
            this.dgvMatHang.PaintStyleName = "UltraFlat";
            this.dgvMatHang.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 61;
            // 
            // Ten
            // 
            this.Ten.Caption = "Mặt hàng";
            this.Ten.FieldName = "MatHang";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 244;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 124;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 124;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.ThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 146;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateKetThuc);
            this.groupBox1.Controls.Add(this.dateBatDau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(585, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = null;
            this.dateKetThuc.Location = new System.Drawing.Point(220, 79);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dateKetThuc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateKetThuc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateKetThuc.Size = new System.Drawing.Size(260, 28);
            this.dateKetThuc.TabIndex = 7;
            this.dateKetThuc.EditValueChanged += new System.EventHandler(this.dateKetThuc_EditValueChanged);
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = null;
            this.dateBatDau.Location = new System.Drawing.Point(220, 32);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateBatDau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateBatDau.Properties.Appearance.Options.UseFont = true;
            this.dateBatDau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateBatDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateBatDau.Size = new System.Drawing.Size(260, 28);
            this.dateBatDau.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày : ";
            // 
            // ThongKeMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeMonAn";
            this.Size = new System.Drawing.Size(1682, 588);
            this.Load += new System.EventHandler(this.ThongKeMonAn_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl dgvMatHangMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
        private DevExpress.XtraEditors.DateEdit dateBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}
