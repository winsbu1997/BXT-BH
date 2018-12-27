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
    public partial class ThongKeBanHang : UserControl
    {
        private CSDL db = Provider.db;
        public ThongKeBanHang()
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
                HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == ID).FirstOrDefault();

                txtMaPhieuNhap.Text = "HD" + hd.ID.ToString();
                dateNgayBan.Text = ((DateTime)hd.NGAYBAN).ToString("dd/MM/yyyy");
                txtNhanVien.Text = db.NHANVIENs.Where(p => p.ID == hd.NHANVIENID).FirstOrDefault().TEN;
                txtTongChiPhi.Text = ((int)hd.TONGTIEN).ToString("N0");

                LoadCHITIETHOADON();
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
                dgvPhieuNhapMain.DataSource = db.HOADONBANs.ToList()
                                               .Where(p => p.NGAYBAN >= dateBatDau.DateTime && p.NGAYBAN <= dateKetThuc.DateTime)
                                               .OrderBy(p => p.NGAYBAN)
                                               .Select(p => new
                                               {
                                                   ID = p.ID,
                                                   TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                   MaHoaDon = "HD" + p.ID.ToString(),
                                                   Ngay = ((DateTime)p.NGAYBAN).ToString("dd/MM/yyyy"),
                                                   NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                               })
                                               .ToList();
                txtTongGiaTri.Text = "Tổng giá trị : " + ((int)db.HOADONBANs.ToList()
                                                           .Where(p => p.NGAYBAN >= dateBatDau.DateTime && p.NGAYBAN <= dateKetThuc.DateTime)
                                                           .OrderBy(p => p.NGAYBAN)
                                                           .Select(p => new
                                                           {
                                                               ID = p.ID,
                                                               ChiPhi = p.TONGTIEN,
                                                               TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                               MaHoaDon = "HD" + p.ID.ToString(),
                                                               Ngay = ((DateTime)p.NGAYBAN).ToString("dd/MM/yyyy"),
                                                               NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                                           })
                                                           .Sum(p => p.ChiPhi))
                                                           .ToString("N0");

                LoadCHITIETHOADON();
            }
            catch { }
        }

        private void LoadCHITIETHOADON()
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == ID).FirstOrDefault();

                int i = 0;
                dgvChiTietNhapMain.DataSource = db.CHITIETHDBs.Where(p => p.HOADONBANID == hd.ID).ToList()
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
        private void ThongKeBanHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvDanhSachHoaDon();
        }
        #endregion
        #region Event
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == ID).FirstOrDefault();
                FrmRpHoaDon form = new FrmRpHoaDon(hd, (int)hd.KHUYENMAI);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có hóa đơn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvDanhSachHoaDon();
        }

        private void dgvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();
        }
        #endregion

    }
}
