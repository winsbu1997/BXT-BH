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
    public partial class QuanLyBanAn : UserControl
    {
        int index = 0, index1 = 0;
        public CSDL db = Provider.db;
        int flag;
        public QuanLyBanAn()
        {
            InitializeComponent();
            Provider.Reload();
        }
        #region Hàm hỗ trợ
        private void Dis_En(bool e)
        {
            dgvBANANMain.Enabled = e;
            btnThem.Enabled = e;
            btnSua.Enabled = e;
            btnXoa.Enabled = e;
            txtTimKiem.Enabled = e;

            btnLuu.Enabled = !e;
            btnHuy.Enabled = !e;

            txtTenBan.Enabled = !e;
            txtViTri.Enabled = !e;
            cbxKhuVucBan.Enabled = !e;
            txtSoCho.Enabled = !e;
        }

        private void ClearData()
        {
            txtTenBan.Text = "";
            txtViTri.Text = "";
            txtSoCho.Text = "";
            cbxKhuVucBan.ItemIndex = 0;
        }

        private BANAN DanhSachBanAnByID()
        {
            try
            {
                int id = (int)dgvBANAN.GetFocusedRowCellValue("ID");
                BANAN ans = db.BANANs.Where(p => p.ID == id).FirstOrDefault();
                if (ans == null) return new BANAN();
                return ans;
            }
            catch
            {
                return new BANAN();
            }
        }
        private BANAN DanhSachBanAnByForm()
        {
            BANAN ans = new BANAN();
            try
            {
                ans.TEN = txtTenBan.Text;
                ans.VITRI = txtViTri.Text;
                ans.SOCHO = Int32.Parse(txtSoCho.Text);
                ans.KHUVUCBANID = (int)cbxKhuVucBan.EditValue;
                ans.TRANGTHAI = 0;
            }
            catch { }
            return ans;
        }

        private void Binding()
        {
            try
            {
                BANAN tg = DanhSachBanAnByID();

                if (tg.ID == 0) return;

                txtTenBan.Text = tg.TEN;
                txtViTri.Text = tg.VITRI;
                txtSoCho.Text = tg.SOCHO.ToString();
                cbxKhuVucBan.EditValue = tg.KHUVUCBANID;
            }
            catch { }
        }

        private bool Check()
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Tên bàn ăn không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int giasp = Int32.Parse(txtSoCho.Text);
            }
            catch
            {
                MessageBox.Show("Số chỗ của bàn ăn phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckLuaChon()
        {
            BANAN tg = DanhSachBanAnByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Update(ref BANAN cu, BANAN moi)
        {
            cu.TEN = moi.TEN;
            cu.SOCHO = moi.SOCHO;
            cu.VITRI = moi.VITRI;
            cu.KHUVUCBANID = moi.KHUVUCBANID;
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            ClearData();

            /// Load combobox khu vực bàn
            cbxKhuVucBan.Properties.DataSource = db.KHUVUCBANs
                                                   .Select(p => new
                                                   {
                                                       TEN = p.TEN,
                                                       ID = p.ID
                                                   }).ToList();
            cbxKhuVucBan.Properties.DisplayMember = "TEN";
            cbxKhuVucBan.Properties.ValueMember = "ID";
            cbxKhuVucBan.ItemIndex = 0;
        }
        private void LoadDanhSachBanAn()
        {
            string key = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listBANAN = db.BANANs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  TEN = p.TEN,
                                  SOCHO = p.SOCHO,
                                  VITRI = p.VITRI,
                                  KHUVUCBAN = db.KHUVUCBANs.Where(z => z.ID == p.KHUVUCBANID).FirstOrDefault().TEN
                              })
                              .ToList();

            dgvBANANMain.DataSource = listBANAN.ToList()
                                         .Where(p => p.TEN.ToUpper().Contains(key) || p.VITRI.ToUpper().Contains(key) || p.KHUVUCBAN.ToUpper().Contains(key))
                                         .Select(p => new
                                         {
                                             ID = p.ID,
                                             STT = ++i,
                                             TEN = p.TEN,
                                             SOCHO = p.SOCHO,
                                             VITRI = p.VITRI,
                                             KHUVUCBAN = p.KHUVUCBAN
                                         }).ToList();

            Binding();

            /// Load lại dòng đang chọn
            try
            {
                index = index1;
                dgvBANAN.FocusedRowHandle = index;
                dgvBANANMain.Select();
            }
            catch { }
        }
        private void QuanLyBanAn_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDanhSachBanAn();
            Dis_En(true);
        }
        #endregion

        #region Sự kiện

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            ClearData();
            Dis_En(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_En(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            BANAN cu = DanhSachBanAnByID();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa bàn ăn " + cu.TEN + "?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);

            if (rs == DialogResult.Cancel) return;

            try
            {
                db.BANANs.Remove(cu);
                db.SaveChanges();
                MessageBox.Show("Xóa thông tin bàn ăn thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thông tin bàn ăn thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            LoadDanhSachBanAn();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Dis_En(true);
            Binding();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BANAN moi = DanhSachBanAnByForm();
            if (!Check()) return;
            if (flag == 0)
            {
                db.BANANs.Add(moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Thêm thông tin bàn ăn thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thông tin bàn ăn thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CheckLuaChon() == false) return;
                BANAN cu = DanhSachBanAnByID();
                Update(ref cu, moi);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sưa thông tin bàn ăn thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin bàn ăn thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            LoadDanhSachBanAn();
            Dis_En(true);
            return;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachBanAn();
            txtTimKiem.Focus();
        }

        private void dgvBANAN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
            try
            {
                index1 = index;
                index = dgvBANAN.FocusedRowHandle;
            }
            catch { }
        }
        #endregion
    }
}
