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
    public partial class FrmRpHoaDon : Form
    {
        private CSDL db = Provider.db;
        private HOADONBAN hd = new HOADONBAN();
        private int khuyenmai = 0;
        public FrmRpHoaDon(HOADONBAN z,int km)
        {
            InitializeComponent();
            Provider.Reload();
            hd = z;
            khuyenmai = km;

            if (khuyenmai < 0) khuyenmai = 0;
            if (khuyenmai > 100) khuyenmai = 100;            
        }
        private void FrmRpHoaDon_Load(object sender, EventArgs e)
        {
            int i = 0;
            RpHoaDon inHD = new Report_Viewer.RpHoaDon();
            foreach (DevExpress.XtraReports.Parameters.Parameter pr in inHD.Parameters) pr.Visible = false;
            Provider.data = db.CHITIETHDBs.Where(p => p.HOADONBANID == hd.ID).ToList()
                                    .Select(p => new HoaDonData
                                    {
                                        STT = ++i,
                                        MatHang = db.MATHANGs.Where(k => k.ID == p.MATHANGID).FirstOrDefault().TEN,
                                        SoLuong = p.SOLUONG,
                                        DonGia = ((int)p.DONGIA).ToString("N0"),
                                        ThanhTien = ((int)p.THANHTIEN).ToString("N0"),
                                        DonViTinh = db.MATHANGs.Where(k => k.ID == p.MATHANGID).FirstOrDefault().DONVITINH
                                    }).ToList();
            int tKhuyenMai = (int)((float)hd.TONGTIEN / 100.0 * khuyenmai);
            int tThanhToan = ((int)hd.TONGTIEN - tKhuyenMai);
            string MaHDB = "HD" + hd.ID.ToString();
            string TenNV = db.NHANVIENs.Where(p => p.ID == hd.NHANVIENID).FirstOrDefault().TEN;
            string TongTien = ((int)hd.TONGTIEN).ToString("N0");
            string KhuyenMai = tKhuyenMai.ToString("N0");
            string NgayBan = ((DateTime)hd.NGAYBAN).ToString("dd/MM/yyyy");
            string ThanhToan = tThanhToan.ToString("N0");
            inHD.InitData(MaHDB, TenNV, TongTien, KhuyenMai, NgayBan, ThanhToan);
            documentViewer1.DocumentSource = inHD;
            inHD.CreateDocument();
        }
    }
}
