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
    public partial class QuanLiNhanVien : UserControl
    {
        int index = 0, index1 = 0;
        int flag;
        private CSDL db = Provider.db;
        public QuanLiNhanVien()
        {
            InitializeComponent();
            Provider.Reload();
        }

        #region Hàm hỗ trợ
        private void Dis_En(bool e)
        {
            grcNhanVien.Enabled = e;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;

            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;

            txtEmail.Enabled = !e;
            txtHoTen.Enabled = !e;
            txtSDT.Enabled = !e;
            txtTaiKhoan.Enabled = !e;
            txtQueQuan.Enabled = !e;
            dtNgaySinh.Enabled = !e;
            cbxChucVu.Enabled = !e;
            cbxGioiTinh.Enabled = !e;
        }

        private void ClearData()
        {
            cbxGioiTinh.SelectedIndex = 0;
            cbxChucVu.SelectedIndex = 0;
            dtNgaySinh.DateTime = DateTime.Now;

            txtHoTen.Text = "";
            txtTitleHoTen.Text = "";
            txtTitleChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtTaiKhoan.Text = "";
            txtQueQuan.Text = "";

            ptbHinhAnh.Image = null;
        }

        private NHANVIEN DanhSachNhanVienByID()
        {
            try
            {
                int id = (int)dgvNhanVien.GetFocusedRowCellValue("ID");
                NHANVIEN nv = db.NHANVIENs.Where(p => p.ID == id).FirstOrDefault();
                if (nv == null) return new NHANVIEN();
                return nv;
            }
            catch
            {
                return new NHANVIEN();
            }
        }
        private NHANVIEN DanhSachNhanVienByForm()
        {
            NHANVIEN nv = new NHANVIEN();
            try
            {
                nv.MATKHAU = "123";
                nv.TAIKHOAN = txtTaiKhoan.Text;

                nv.TEN = txtHoTen.Text;
                nv.CHUCVU = cbxChucVu.SelectedIndex;
                nv.GIOITINH = cbxGioiTinh.SelectedIndex;
                nv.NGAYSINH = dtNgaySinh.DateTime;
                nv.SDT = txtSDT.Text;
                nv.QUEQUAN = txtQueQuan.Text;
                nv.EMAIL = txtEmail.Text;

                nv.HINHANH = Provider.imageToByteArray(ptbHinhAnh.Image);
            }
            catch { }

            return nv;
        }

        private void Binding()
        {
            try
            {
                NHANVIEN nhanvien = DanhSachNhanVienByID();

                if (nhanvien.ID == 0) return;

                txtHoTen.Text = nhanvien.TEN;
                txtTitleHoTen.Text = nhanvien.TEN;
                txtTitleChucVu.Text = ((int)nhanvien.CHUCVU == 0) ? "Quản trị viên" : "Nhân viên";
                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                dtNgaySinh.DateTime = (DateTime)nhanvien.NGAYSINH;
                txtSDT.Text = nhanvien.SDT;
                txtEmail.Text = nhanvien.EMAIL;
                txtQueQuan.Text = nhanvien.QUEQUAN;
                txtTaiKhoan.Text = nhanvien.TAIKHOAN;

                cbxChucVu.SelectedIndex = (int)nhanvien.CHUCVU;
                cbxGioiTinh.SelectedIndex = (int)nhanvien.GIOITINH;

                ptbHinhAnh.Image = null;
                ptbHinhAnh.Image = Provider.byteArrayToImage(nhanvien.HINHANH);
            }
            catch { }
        }

        private bool Check()
        {
            if (ptbHinhAnh.Image == null)
            {
                MessageBox.Show("Ảnh của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản của nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            NHANVIEN k = DanhSachNhanVienByID();
            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == txtTaiKhoan.Text && p.ID != k.ID).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Tài khoản đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            NHANVIEN tg = DanhSachNhanVienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có nhân viên nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Update(ref NHANVIEN cu, NHANVIEN moi)
        {
            cu.TEN = moi.TEN;
            cu.CHUCVU = moi.CHUCVU;
            cu.GIOITINH = moi.GIOITINH;
            cu.NGAYSINH = moi.NGAYSINH;
            cu.SDT = moi.SDT;
            cu.EMAIL = moi.EMAIL;
            cu.QUEQUAN = moi.QUEQUAN;
            cu.HINHANH = moi.HINHANH;
        }
        #endregion

        #region LoadForm
        private void LoadDanhSachNhanVien()
        {
            int i = 0;
            string key = txtTimKiem.Text.Trim().ToUpper();
            var listNV = db.NHANVIENs.ToList()
                            .Select(p => new
                            {
                                ID = p.ID,
                                TEN = p.TEN,
                                GIOITINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                                CHUCVU = (p.CHUCVU == 1) ? "Nhân viên" : "Quản Trị Viên"
                            }).ToList();
            grcNhanVien.DataSource = listNV.ToList()
                                     .Where(p => p.TEN.ToUpper().Contains(key))
                                     .Select(p => new
                                     {
                                         ID = p.ID,
                                         STT = ++i,
                                         TEN = p.TEN,
                                         GIOITINH = p.GIOITINH,
                                         CHUCVU = p.CHUCVU
                                     }).ToList();
            Binding();
            // load dong da chon
            try
            {
                index = index1;
                dgvNhanVien.FocusedRowHandle = index;
                grcNhanVien.Select();
            }
            catch { }
        }
        private void QuanLiNhanVien_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadDanhSachNhanVien();
            Dis_En(true);
        }
        #endregion

        #region Sự Kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_En(false);
            ClearData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_En(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckLuaChon() == false) return;
            NHANVIEN nv = DanhSachNhanVienByID();
            if (nv.CHUCVU == 0 && nv.TAIKHOAN == Provider.nhanvien.TAIKHOAN)
            {
                MessageBox.Show("Bạn không được phép xóa chính mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa nhân viên " + nv.TEN + "?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            try
            {
                db.NHANVIENs.Remove(nv);
                db.SaveChanges();
                MessageBox.Show("Xóa thông tin nhân viên thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin nhân viên thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            LoadDanhSachNhanVien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN moi = DanhSachNhanVienByForm();
            if (!Check()) return;
            // them nv
            if (flag == 0)
            {
                db.NHANVIENs.Add(moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin nhân viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin nhân viên thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            // sua nv
            else
            {
                if (CheckLuaChon() == false) return;
                NHANVIEN cu = DanhSachNhanVienByID();
                if (cu.TAIKHOAN == "Admin" && moi.CHUCVU == 1)
                {
                    MessageBox.Show("Bạn không được sửa quyền của chính mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Update(ref cu, moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sửa thông tin nhân viên thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadDanhSachNhanVien();
            Dis_En(true);
            return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_En(true);
            Binding();
            return;
        }

        private void dgvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
            try
            {
                index1 = index;
                index = dgvNhanVien.FocusedRowHandle;
            }
            catch { }
        }

        private void ptbHinhAnh_Click(object sender, EventArgs e)
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
                ptbHinhAnh.Image = image;
                ptbHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            }
            catch
            {
                MessageBox.Show("Định dạng ảnh không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
            txtTimKiem.Focus();
        }

        #endregion
    }
}
