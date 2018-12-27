using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using CNPM_QLBH.Model;

namespace CNPM_QLBH.Report_Viewer
{
    public partial class RpHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        private CSDL db = Provider.db;
        public RpHoaDon()
        {
            InitializeComponent();
            Provider.Reload();
        }

        public void InitData(string MaHDB, string TenNV, string TongTien, string KhuyenMai, string NgayBan, string ThanhToan)
        {
            pMaHDB.Value = MaHDB;
            dateNgayBan.Value = NgayBan;
            pTenNV.Value = TenNV;
            pTongTien.Value = TongTien;
            pThanhToan.Value = ThanhToan;
            pKhuyenMai.Value = KhuyenMai;
            objectDataSource1.DataSource = Provider.data;
        }
    }
}
