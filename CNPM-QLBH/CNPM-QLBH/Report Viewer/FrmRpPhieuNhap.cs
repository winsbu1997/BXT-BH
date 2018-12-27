using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_QLBH.Model;

namespace CNPM_QLBH.Report_Viewer
{
    public partial class FrmRpPhieuNhap : Form
    {
        private CSDL db = Provider.db;
        private PHIEUNHAP pn = new PHIEUNHAP();
        public FrmRpPhieuNhap(PHIEUNHAP z)
        {
            InitializeComponent();
            Provider.Reload();
            pn = z;
        }

        private void FrmRpPhieuNhap_Load(object sender, EventArgs e)
        {
            int i = 0;
            Provider.data = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == pn.ID).ToList()
                                    .Select(p => new HoaDonData()
                                    {
                                        STT = ++i,
                                        MatHang = db.MATHANGs.Where(k => k.ID == p.MATHANGID).FirstOrDefault().TEN,
                                        SoLuong = p.SOLUONG,
                                        DonGia = ((int)p.DONGIA).ToString("N0"),
                                        ThanhTien = ((int)p.THANHTIEN).ToString("N0"),
                                    }).ToList();

            string MaPN = "MPN" + pn.ID.ToString();
            string TenNV = db.NHANVIENs.Where(p => p.ID == pn.NHANVIENID).FirstOrDefault().TEN;
            string TongTien = ((int)pn.TONGTIEN).ToString("N0");
            string NgayNhap = ((DateTime)pn.NGAYNHAP).ToString("dd/MM/yyyy");

            RpPhieuNhap inHD = new Report_Viewer.RpPhieuNhap();
            foreach (DevExpress.XtraReports.Parameters.Parameter pr in inHD.Parameters) pr.Visible = false;
            inHD.InitData(MaPN, TenNV, TongTien,NgayNhap);
            documentViewer1.DocumentSource = inHD;
            inHD.CreateDocument();
        }
    }
}
