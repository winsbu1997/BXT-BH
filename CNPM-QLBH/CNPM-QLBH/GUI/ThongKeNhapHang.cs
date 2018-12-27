using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_QLBH.Model;
using CNPM_QLBH.Report_Viewer;
namespace CNPM_QLBH.GUI
{
    public partial class ThongKeNhapHang : UserControl
    {
        private CSDL db = Provider.db;
        public ThongKeNhapHang()
        {
            InitializeComponent();
            Provider.Reload();
            dgvChiTietNhapMain.DataSource = null;
            dgvPhieuNhapMain.DataSource = null;
        }
        #region Method
        private void UpdateDetail()
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                PHIEUNHAP hd = db.PHIEUNHAPs.Where(p => p.ID == ID).FirstOrDefault();

                txtMaPhieuNhap.Text = "MPN" + hd.ID.ToString();
                dateNgayBan.Text = ((DateTime)hd.NGAYNHAP).ToString("dd/MM/yyyy");
                txtNhanVien.Text = db.NHANVIENs.Where(p => p.ID == hd.NHANVIENID).FirstOrDefault().TEN;
                txtTongChiPhi.Text = ((int)hd.TONGTIEN).ToString("N0");

                LoadCHITIETNHAP();
            }
            catch { }
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            dateBatDau.DateTime = DateTime.Now.AddDays(-30);
            dateKetThuc.DateTime = DateTime.Now;
        }

        private void LoadDgvDanhSachHoaDon()
        {
            txtTongGiaTri.Text = "Tổng giá trị: 0";
            try
            {
                dgvPhieuNhapMain.DataSource = db.PHIEUNHAPs.ToList()
                                               .Where(p => p.NGAYNHAP >= dateBatDau.DateTime && p.NGAYNHAP <= dateKetThuc.DateTime)
                                               .OrderBy(p => p.NGAYNHAP)
                                               .Select(p => new
                                               {
                                                   ID = p.ID,
                                                   TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                   MaHoaDon = "MPN" + p.ID.ToString(),
                                                   Ngay = ((DateTime)p.NGAYNHAP).ToString("dd/MM/yyyy"),
                                                   NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                               })
                                               .ToList();
                txtTongGiaTri.Text = "Tổng giá trị : " + ((int)db.PHIEUNHAPs.ToList()
                                                           .Where(p => p.NGAYNHAP >= dateBatDau.DateTime && p.NGAYNHAP <= dateKetThuc.DateTime)
                                                           .OrderBy(p => p.NGAYNHAP)
                                                           .Select(p => new
                                                           {
                                                               ID = p.ID,
                                                               ChiPhi = p.TONGTIEN,
                                                               TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                               MaHoaDon = "MPN" + p.ID.ToString(),
                                                               Ngay = ((DateTime)p.NGAYNHAP).ToString("dd/MM/yyyy"),
                                                               NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                                           })
                                                           .Sum(p => p.ChiPhi))
                                                           .ToString("N0");

                LoadCHITIETNHAP();
            }
            catch { }
        }

        private void LoadCHITIETNHAP()
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                PHIEUNHAP hd = db.PHIEUNHAPs.Where(p => p.ID == ID).FirstOrDefault();

                int i = 0;
                dgvChiTietNhapMain.DataSource = db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == hd.ID).ToList()
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++i,
                                                    MatHang = db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                                    DonGia = ((int)p.DONGIA).ToString("N0"),
                                                    SoLuong = p.SOLUONG,
                                                    ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                                })
                                                .ToList();
            }
            catch { }
        }

        private void ThongKeNhapHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvDanhSachHoaDon();
        }
        #endregion

        #region Event

        private void dgvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();
        }

        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvDanhSachHoaDon();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                PHIEUNHAP hd = db.PHIEUNHAPs.Where(p => p.ID == ID).FirstOrDefault();
                FrmRpPhieuNhap form = new FrmRpPhieuNhap(hd);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có phiếu nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }
        #endregion
    }
}
