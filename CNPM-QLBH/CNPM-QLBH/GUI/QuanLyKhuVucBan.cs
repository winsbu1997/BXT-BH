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
    public partial class QuanLyKhuVucBan : UserControl
    {
        int index = 0, index1 = 0;
        public CSDL db = Provider.db;
        int flag;
        public QuanLyKhuVucBan()
        {
            InitializeComponent();
            Provider.Reload();
        }
        #region Hàm hỗ trợ
        private void Dis_En(bool e)
        {
            dgvKhuVucMain.Enabled = e;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            txtTimKiem.Enabled = e;

            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;
            txtTenKhuVuc.Enabled = !e;
            txtViTri.Enabled = !e;
        }

        private void ClearData()
        {
            txtTenKhuVuc.Text = "";
            txtViTri.Text = "";
        }

        private KHUVUCBAN DanhSachKhuVucByID()
        {
            try
            {
                int id = (int)dgvKhuVuc.GetFocusedRowCellValue("ID");
                KHUVUCBAN kv = db.KHUVUCBANs.Where(p => p.ID == id).FirstOrDefault();
                if (kv == null) return new KHUVUCBAN();
                return kv;
            }
            catch
            {
                return new KHUVUCBAN();
            }
        }
        private KHUVUCBAN DanhSachKhuVucByForm()
        {
            KHUVUCBAN kv = new KHUVUCBAN();
            try
            {
                kv.TEN = txtTenKhuVuc.Text;
                kv.VITRI = txtViTri.Text;
            }
            catch { }

            return kv;
        }

        private void Binding()
        {
            try
            {
                KHUVUCBAN kv = DanhSachKhuVucByID();
                if (kv.ID == 0) return;
                txtTenKhuVuc.Text = kv.TEN;
                txtViTri.Text = kv.VITRI;              
            }
            catch { }
        }

        private bool Check()
        {
            if (txtTenKhuVuc.Text == "")
            {
                MessageBox.Show("Tên khu vực không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            KHUVUCBAN kv = DanhSachKhuVucByID();
            if (kv.ID == 0)
            {
                MessageBox.Show("Chưa có khu vực nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Update(ref KHUVUCBAN cu, KHUVUCBAN moi)
        {
            cu.TEN = moi.TEN;
            cu.VITRI = moi.VITRI;
        }
        #endregion

        #region LoadForm
        private void LoadDanhSachKhuVuc()
        {
            int i = 0;
            string key = txtTimKiem.Text.Trim().ToUpper();
            var listKV = db.KHUVUCBANs.ToList()
                            .Select(p => new
                            {
                                ID = p.ID,
                                TEN = p.TEN,
                                VITRI = p.VITRI
                            }).ToList();
            dgvKhuVucMain.DataSource = listKV.ToList()
                                     .Where(p => p.TEN.ToUpper().Contains(key) || p.VITRI.ToUpper().Contains(key))
                                     .Select(p => new
                                     {
                                         ID = p.ID,
                                         STT = ++i,
                                         TEN = p.TEN,
                                         VITRI = p.VITRI
                                     }).ToList();
            Binding();
            // load dong da chon
            try
            {
                index = index1;
                dgvKhuVuc.FocusedRowHandle = index;
                dgvKhuVucMain.Select();
            }
            catch { }
        }
        private void QuanLyKhuVucBan_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadDanhSachKhuVuc();
            Dis_En(true);
        }
        #endregion

        #region Sự kiện

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
            KHUVUCBAN kv = DanhSachKhuVucByID();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa khu vực " + kv.TEN + "?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            try
            {
                db.KHUVUCBANs.Remove(kv);
                db.SaveChanges();
                MessageBox.Show("Xóa thông tin khu vực thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin khu vực thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            LoadDanhSachKhuVuc();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_En(true);
            Binding();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            KHUVUCBAN moi = DanhSachKhuVucByForm();
            if (!Check()) return;
            if (flag == 0)
            {
                db.KHUVUCBANs.Add(moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin khu vực thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin khu vực thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CheckLuaChon() == false) return;
                KHUVUCBAN cu = DanhSachKhuVucByID();
                Update(ref cu, moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sưa thông tin khu vực thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin khu vực thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadDanhSachKhuVuc();
            Dis_En(true);
            return;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachKhuVuc();
            txtTimKiem.Focus();
        }
        private void dgvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
            try
            {
                index1 = index;
                index = dgvKhuVuc.FocusedRowHandle;
            }
            catch { }
        }

        #endregion
    }
}
