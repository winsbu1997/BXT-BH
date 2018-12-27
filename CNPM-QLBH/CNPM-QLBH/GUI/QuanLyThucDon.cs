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

namespace CNPM_QLBH.GUI
{
    public partial class QuanLyThucDon : UserControl
    {
        int flag,flag1;
        private CSDL db = Provider.db;
        int index = 0, index1 = 0, index2 = 0, index3 = 0;
        public QuanLyThucDon()
        {
            InitializeComponent();
            Provider.Reload();
        }
        #region Loại mặt hàng

        #region Hàm hỗ trợ loại mặt hàng
        private void Dis_En(bool e)
        {
            dgvLoaiMatHangMain.Enabled = e;
            btnThemLoai.Enabled = e;
            btnSuaLoai.Enabled = e;
            btnXoaLoai.Enabled = e;
            txtTimKiemLoai.Enabled = e;

            btnLuuLoai.Enabled = !e;
            btnHuyLoai.Enabled = !e;
            txtTenLoai.Enabled = !e;
        }
        private void ClearData()
        {
            dgvLoaiMatHang.FocusedRowHandle = 0;
            dgvLoaiMatHangMain.Select();
            txtTenLoai.Text = "";
        }
        private LOAIHANG DanhSachLoaiHangByID()
        {
            try
            {
                int id = (int)dgvLoaiMatHang.GetFocusedRowCellValue("ID");
                LOAIHANG lh = db.LOAIHANGs.Where(p => p.ID == id).FirstOrDefault();
                if (lh == null) return new LOAIHANG();
                return lh;
            }
            catch
            {
                return new LOAIHANG();
            }
        }
        private LOAIHANG DanhSachLoaiHangByForm()
        {
            LOAIHANG lh = new LOAIHANG();
            try
            {
                lh.TEN = txtTenLoai.Text;
            }
            catch { }
            return lh;
        }
        private void Binding()
        {
            try
            {
                LOAIHANG lh = DanhSachLoaiHangByID();
                if (lh.ID == 0) return;
                txtTenLoai.Text = lh.TEN;
            }
            catch { }
        }
        private bool Check()
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Tên loại hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            LOAIHANG lh = DanhSachLoaiHangByID();
            int cnt = db.LOAIHANGs.Where(p => p.TEN == txtTenLoai.Text).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Tên loại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckLuaChon()
        {
            LOAIHANG lh = DanhSachLoaiHangByID();
            if (lh.ID == 0)
            {
                MessageBox.Show("Chưa có loại hàng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Update(ref LOAIHANG cu, LOAIHANG moi)
        {
            cu.TEN = moi.TEN;
        }
        #endregion

        #region LoadForm loại mặt hàng
        private void LoadDanhSachLoaiHang()
        {
            int i = 0;
            string key = txtTimKiemLoai.Text.Trim().ToUpper();
            var listLH = db.LOAIHANGs.ToList()
                        .Select(p => new
                        {
                            ID = p.ID,
                            TENLOAI = p.TEN
                        }).ToList();
            dgvLoaiMatHangMain.DataSource = listLH.ToList()
                                        .Where(p => p.TENLOAI.ToUpper().Contains(key))
                                        .Select(p => new
                                        {
                                            ID = p.ID,
                                            STT1 = ++i,
                                            TENLOAI = p.TENLOAI
                                        }).ToList();
            Binding();
            try
            {
                index = index1;
                dgvLoaiMatHang.FocusedRowHandle = index;
                dgvLoaiMatHangMain.Select();
            }
            catch { }
        }

        #endregion

        #region Sự kiện Loại Mặt Hàng
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_En(false);
            ClearData();
            panel8.Enabled = false;
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            flag = 1;
            panel8.Enabled = false;
            Dis_En(false);
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if (CheckLuaChon() == false) return;
            LOAIHANG lh = DanhSachLoaiHangByID();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa loại hàng " + lh.TEN + "?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            try
            {
                db.LOAIHANGs.Remove(lh);
                db.SaveChanges();
                MessageBox.Show("Xóa thông tin loại hàng thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin loại hàng thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            LoadDanhSachLoaiHang();
        }

        private void btnLuuLoai_Click(object sender, EventArgs e)
        {
            if (!Check()) return;
            LOAIHANG moi = DanhSachLoaiHangByForm();            
            if (flag == 0)
            {
                db.LOAIHANGs.Add(moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin loại hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin loại hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CheckLuaChon() == false) return;
                LOAIHANG cu = DanhSachLoaiHangByID();
                Update(ref cu, moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sủa thông tin loại hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin loại hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadDanhSachLoaiHang();
            Dis_En(true);
            panel8.Enabled = true;
        }

        private void btnHuyLoai_Click(object sender, EventArgs e)
        {
            Dis_En(true);
            panel8.Enabled = true;
            Binding();
        }

        private void txtTimKiemLoai_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachLoaiHang();
            txtTimKiemLoai.Focus();
        }
        private void dgvLoaiMatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
            try
            {
                index1 = index;
                index = dgvLoaiMatHang.FocusedRowHandle;
            }
            catch { }
            LocTheoLoaiHang();
            //MessageBox.Show(index.ToString() + " / truoc: " + index1.ToString());
        }


        #endregion
        #endregion

        /// <summary>
        /// Mặt Hàng
        /// </summary>
        #region Mặt Hàng
        #region Hàm hỗ trợ mặt hàng
        private void Dis_En1(bool e)
        {
            dgvMATHANGMain.Enabled = e;
            txtTimKiem.Enabled = e;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;

            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;
            txtTen.Enabled = !e;
            txtGiaBan.Enabled = !e;
            txtDonViTinh.Enabled = !e;
            ptbMonAn.Enabled = !e;
        }
        private void ClearData1()
        {
            txtTen.Text = "";
            txtDonViTinh.Text = "";
            txtGiaBan.Text = "";
            ptbMonAn.Image = null;
        }
        private MATHANG DanhSachMatHangByID()
        {
            try
            {
                int id = (int)dgvMATHANG.GetFocusedRowCellValue("ID");
                MATHANG mh = db.MATHANGs.Where(p => p.ID == id).FirstOrDefault();
                if (mh == null) return new MATHANG();
                return mh;
            }
            catch
            {
                return new MATHANG();
            }
        }
        private MATHANG DanhSachMatHangByForm()
        {
            MATHANG mh = new MATHANG();
            try
            {
                mh.TEN = txtTen.Text;
                mh.GIABAN = Convert.ToInt32(txtGiaBan.Text);
                mh.DONVITINH = txtDonViTinh.Text;
                mh.LOAIHANGID = (int)dgvLoaiMatHang.GetFocusedRowCellValue("ID");
                mh.HINHANH = Provider.imageToByteArray(ptbMonAn.Image);               
            }
            catch { }
            return mh;
        }
        private void Binding1()
        {
            try
            {
                MATHANG mh = DanhSachMatHangByID();
                if (mh.ID == 0) return;

                txtTen.Text = mh.TEN;
                txtGiaBan.Text = mh.GIABAN.ToString();
                txtDonViTinh.Text = mh.DONVITINH;
                ptbMonAn.Image = null;
                ptbMonAn.Image = Provider.byteArrayToImage(mh.HINHANH);
            }
            catch { }
        }
        private bool Check1()
        {
            if (ptbMonAn.Image == null)
            {
                MessageBox.Show("Ảnh của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Giá bán của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDonViTinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính của mặt hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckLuaChon1()
        {
            MATHANG mh = DanhSachMatHangByID();
            if (mh.ID == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Update1(ref MATHANG cu, MATHANG moi)
        {
            cu.TEN = moi.TEN;
            cu.DONVITINH = moi.DONVITINH;
            cu.GIABAN = moi.GIABAN;
            cu.HINHANH = moi.HINHANH;
            cu.LOAIHANGID = moi.LOAIHANGID;
        }
        #endregion

        #region LoadForm mặt hàng
        private void LoadDanhSachMatHang()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listMatHang = db.MATHANGs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  TEN = p.TEN,
                                  DONVITINH = p.DONVITINH,
                                  GIABAN = ((int)p.GIABAN).ToString("N0") + " vnđ",
                                  LOAIHANG = db.LOAIHANGs.Where(z => z.ID == p.LOAIHANGID).FirstOrDefault().TEN.ToString()
                              })
                              .ToList();

            dgvMATHANGMain.DataSource = listMatHang.ToList()
                                         .Where(p => p.TEN.ToUpper().Contains(keyWord))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             TEN = p.TEN,
                                             DONVITINH = p.DONVITINH,
                                             GIABAN = p.GIABAN,
                                             LOAIHANG = p.LOAIHANG
                                         }).ToList();

            Binding1();

            /// Load lại dòng đang chọn
            try
            {
                index2 = index3;
                dgvMATHANG.FocusedRowHandle = index2;
                dgvMATHANGMain.Select();
            }
            catch { }
        }
        #endregion

        #region Sự kiện mặt hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag1 = 0;
            Dis_En1(false);
            ClearData1();
            panel4.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckLuaChon1() == false) return;
            MATHANG mh = DanhSachMatHangByID();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa mặt hàng " + mh.TEN + "?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            try
            {
                KHO kho = db.KHOes.Where(p => p.MATHANGID == mh.ID).FirstOrDefault();
                db.KHOes.Remove(kho);
                db.SaveChanges();
                db.MATHANGs.Remove(mh);
                db.SaveChanges();
                MessageBox.Show("Xóa thông tin mặt hàng thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                LoadDanhSachMatHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin mặt hàng thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }       
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag1 = 1;
            Dis_En1(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MATHANG moi = DanhSachMatHangByForm();
            if (!Check1()) return;
            if (flag1 == 0)
            {
                db.MATHANGs.Add(moi);
                try
                {
                    db.SaveChanges();

                    KHO kho = new KHO();
                    kho.MATHANGID = moi.ID;
                    kho.SOLUONG = 0;
                    db.KHOes.Add(kho);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thông tin mặt hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin mặt hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CheckLuaChon1() == false) return;
                MATHANG cu = DanhSachMatHangByID();
                Update1(ref cu, moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sưa thông tin mặt hàng thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin mặt hàng thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadDanhSachMatHang();
            Dis_En1(true);
            panel4.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_En1(true);
            panel4.Enabled = true;
            Binding1();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachMatHang();
            txtTimKiem.Focus();
        }

        private void dgvMATHANG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding1();
            try
            {
                index3 = index2;
                index2 = dgvMATHANG.FocusedRowHandle;
            }
            catch { }
        }
        private void ptbMonAn_Click(object sender, EventArgs e)
        {
            string path = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                path = open.FileName;
            }
            catch { }
            try
            {
                Image image = Image.FromFile(path);
                ptbMonAn.Image = image;
                ptbMonAn.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion
        #endregion

        #region Xử lý chung
        private void QuanLyThucDon_Load(object sender, EventArgs e)
        {
            ClearData();
            Dis_En(true);
            LoadDanhSachLoaiHang();
            ClearData1();
            Dis_En1(true);
            LoadDanhSachMatHang();
        }
        private void LocTheoLoaiHang()
        {
            dgvMATHANG.ActiveFilterString = "[LOAIHANG]= '" + txtTenLoai.Text + "'";
        }
        #endregion
    }
}
