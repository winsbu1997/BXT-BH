using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CNPM_QLBH.Report_Viewer
{
    public partial class RpPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public RpPhieuNhap()
        {
            InitializeComponent();
        }
        public void InitData(string MaPN, string TenNV, string TongTien, string NgayNhap)
        {
            pMaPN.Value = MaPN;
            pNgayNhap.Value = NgayNhap;
            pTenNV.Value = TenNV;
            pTongTien.Value = TongTien;
            objectDataSource1.DataSource = Provider.data;
        }
    }
}
