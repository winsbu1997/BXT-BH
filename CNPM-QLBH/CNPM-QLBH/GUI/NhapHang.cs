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
    public partial class NhapHang : UserControl
    {
        private CSDL db = Provider.db;
        int index = 0, index1 = 0;
        public NhapHang()
        {
            InitializeComponent();
            Provider.Reload();
        }

        #region Hàm phụ trợ
        private void Dis_En(bool e)
        {
            btnThem.Enabled = e;
            btnXoa.Enabled = e;
            dgvCHITIETNHAPMain.Enabled = e;
            
            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;
            cbxMatHang.Enabled = !e;
            txtDonViTinh.Enabled = !e;
            txtDonGia.Enabled = !e;
            txtSoLuong.Enabled = !e;
        }
        private void Dis_En1(bool e)
        {
            btnLapPhieuNhap.Enabled = e;
            dateNgayNhap.Enabled = e;
            cbxNhanVien.Enabled = e;

            btnLuuPhieuNhap.Enabled = !e;
        }
        private void LoadPhieuNhap()
        {
            groupChiTietNhap.Enabled = true;
            Dis_En1(false);
            Dis_En(true);
            LoadDanhSachChiTietNhap();
        }

        private void ClearData()
        {
            cbxMatHang.ItemIndex = 0;
            txtDonGia.Text = "";
            txtSoLuong.Value = 1;
        }
        private void Binding()
        {
            CHITIETNHAP tg = GetChiTietNhapByID();
            txtTongTien.Text = ((int)Provider.phieunhap.TONGTIEN).ToString("N0");
            txtChiPhi.Text = ((int)Provider.phieunhap.TONGTIEN).ToString("N0");

            int id = (int)cbxMatHang.EditValue;
            txtDonViTinh.Text = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault().DONVITINH;

            if (tg.ID == 0) return;
            cbxMatHang.ItemIndex = (int)tg.MATHANGID;
            txtDonViTinh.Text = "";
            txtSoLuong.Value = (int)tg.SOLUONG;
        }
        private  CHITIETNHAP GetChiTietNhapByID()
        {
            try
            {
                int id = (int)dgvCHITIETNHAP.GetFocusedRowCellValue("ID");
                CHITIETNHAP ans = db.CHITIETNHAPs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new CHITIETNHAP();
                return ans;
            }
            catch
            {
                return new CHITIETNHAP();
            }
        }
        private CHITIETNHAP GetChiTietNhapByForm()
        {
            CHITIETNHAP ans = new CHITIETNHAP();

            try
            {
                ans.MATHANGID = (int)cbxMatHang.EditValue;
                ans.SOLUONG = (int)txtSoLuong.Value;
                ans.DONGIA = Int32.Parse(txtDonGia.Text);
                ans.THANHTIEN = ans.SOLUONG * ans.DONGIA;
                ans.PHIEUNHAPID = Provider.phieunhap.ID;
            }
            catch { }

            return ans;
        }

        private bool Check()
        {

            try
            {
                int dongia = Int32.Parse(txtDonGia.Text);

            }
            catch
            {
                MessageBox.Show("Đơn giá phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            CHITIETNHAP tg = GetChiTietNhapByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có chi tiết nhập nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            cbxNhanVien.Properties.DataSource = db.NHANVIENs.ToList().Select(p => new { ID = p.ID, Ten = p.TEN });
            cbxNhanVien.Properties.DisplayMember = "Ten";
            cbxNhanVien.Properties.ValueMember = "ID";

            cbxNhanVien.Enabled = false;
            cbxNhanVien.EditValue = Provider.nhanvien.ID;

            cbxMatHang.Properties.DataSource = db.MATHANGs.Select(p => new { ID = p.ID, Ten = p.TEN }).ToList();
            cbxMatHang.Properties.DisplayMember = "Ten";
            cbxMatHang.Properties.ValueMember = "ID";
            cbxMatHang.ItemIndex = 0;
        }

        private void LoadDanhSachChiTietNhap()
        {
            int i = 0;
            var listChiTietNhap = (db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == Provider.phieunhap.ID).ToList()
                                  .Select(p => new
                                  {
                                      STT = ++i,
                                      ID = p.ID,
                                      MatHang = db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                      DonGia = p.DONGIA,
                                      SoLuong = p.SOLUONG,
                                      ThanhTien = p.THANHTIEN
                                  })
                                  ).ToList();

            dgvCHITIETNHAPMain.DataSource = listChiTietNhap;

            Binding();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvCHITIETNHAP.FocusedRowHandle = index;
                dgvCHITIETNHAPMain.Select();
            }
            catch{}
        }

       

        private void NhapHang_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            if (Provider.phieunhap.ID == 0)
            {
                Dis_En1(true);
                dateNgayNhap.DateTime = DateTime.Now;
                groupChiTietNhap.Enabled = false;
            }
            else
            {
                LoadPhieuNhap();
            }
        }

        
        #endregion

        #region Sự kiện             
        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.NGAYNHAP = dateNgayNhap.DateTime;
            pn.NHANVIENID = (int)cbxNhanVien.EditValue;
            pn.TONGTIEN = 0;
            db.PHIEUNHAPs.Add(pn);

            try
            {
                db.SaveChanges();
                Provider.phieunhap = pn;
                MessageBox.Show("Lập phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                LoadPhieuNhap();
            }
            catch
            {
                MessageBox.Show("Lập phiếu nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thông tin phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dis_En1(true);
            groupChiTietNhap.Enabled = false;

            try
            {
                foreach (var item in db.CHITIETNHAPs.Where(p => p.PHIEUNHAPID == Provider.phieunhap.ID).ToList())
                {
                    KHO kho = db.KHOes.Where(p => p.MATHANGID == item.MATHANGID).FirstOrDefault();
                    kho.SOLUONG += item.SOLUONG;
                }
                db.SaveChanges();
            }
            catch { }
            finally
            {
                Provider.phieunhap = new PHIEUNHAP();
            }
        }
        #region Sự kiện chi tiết nhập
        private void btnThem_Click(object sender, EventArgs e)
        {
            Dis_En(false);
            ClearData();         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                CHITIETNHAP moi = GetChiTietNhapByForm();
                db.CHITIETNHAPs.Add(moi);

                try
                {
                    db.SaveChanges();

                    Provider.phieunhap.TONGTIEN += moi.SOLUONG * moi.DONGIA;
                    db.SaveChanges();

                    MessageBox.Show("Thêm thông tin chi tiết nhập thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin chi tiết nhập thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDanhSachChiTietNhap();
                Dis_En(true);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            CHITIETNHAP cu = GetChiTietNhapByID();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa chi tiết nhập này không?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            try
            {
                Provider.phieunhap.TONGTIEN -= cu.SOLUONG * cu.DONGIA;
                db.CHITIETNHAPs.Remove(cu);
                db.SaveChanges();

                MessageBox.Show("Xóa thông tin chi tiết nhập thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin chi tiết nhập thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            LoadDanhSachChiTietNhap();
            Binding();
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)Provider.phieunhap.ID;
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
            }
        }
        private void Huy_Click(object sender, EventArgs e)
        {
            Dis_En(true);
            Binding();
        }
        #endregion
        //
        private void dgvCHITIETNHAP_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
            try
            {
                index1 = index;
                index = dgvCHITIETNHAP.FocusedRowHandle;
            }
            catch { }
        }

        private void cbxMatHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)cbxMatHang.EditValue;
                txtDonViTinh.Text = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault().DONVITINH;
            }
            catch { }
        }

        #endregion

    }
}
