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
using DevExpress.XtraEditors;
using CNPM_QLBH.Report_Viewer;

namespace CNPM_QLBH.GUI
{
    public partial class BanHang : UserControl
    {
        private CSDL db = Provider.db;
        private int IDBanAn = 0;
        private BANAN table = new BANAN();
        public BanHang()
        {
            InitializeComponent();
            Provider.Reload();
        }
        #region LoadForm
        private void LoadDanhSachHoaDon(int idHoaDon)
        {
            int i = 0;
            var listChiTiet = db.CHITIETHDBs.ToList()
                              .Where(p => p.HOADONBANID == idHoaDon)
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  STT = ++i,
                                  MatHang = db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                  DonGia = ((int)p.DONGIA).ToString("N0"),
                                  SoLuong = p.SOLUONG,
                                  ThanhTien = ((int)(p.DONGIA * p.SOLUONG)).ToString("N0")
                              });

            dgvHoaDonMain.DataSource = listChiTiet;
        }
        private void LoadDanhSachBanAn()
        {
            try
            {
                int KhuVucID = (int)cbxKhuVuc.EditValue;
                var listBanAn = db.BANANs.Where(p => p.KHUVUCBANID == KhuVucID).ToList();

                panelDsBanAn.Controls.Clear();
                foreach (var item in listBanAn)
                {
                    ucBanAn uc = new ucBanAn(item, ucBanAnClick);
                    panelDsBanAn.Controls.Add(uc);
                }

                IDBanAn = listBanAn.FirstOrDefault().ID;
                Binding(IDBanAn);
            }
            catch { }
        }
        private void LoadEmptyTable()
        {
            try
            {
                int KhuVucID = (int)cbxKhuVuc.EditValue;
                cbxCBAN.Properties.DataSource = db.BANANs
                                                   .Where(p => p.KHUVUCBANID == KhuVucID)
                                                   .Where(p => p.TRANGTHAI == 0).ToList()
                                                   .Where(p => p.ID != IDBanAn)
                                                   .Select(p => new
                                                   {
                                                       ID = p.ID,
                                                       BanAn = p.TEN
                                                   }).ToList();
                cbxCBAN.Properties.DisplayMember = "BanAn";
                cbxCBAN.Properties.ValueMember = "ID";

                cbxCBAN.ItemIndex = 0;
            }
            catch { }
        }
        private void LoadInitControl()
        {
            try
            {
                // Load cbx khu vực
                cbxKhuVuc.Properties.DataSource = db.KHUVUCBANs
                                                    .Select(p => new
                                                    {
                                                        ID = p.ID,
                                                        TEN = p.TEN
                                                    }).ToList();
                cbxKhuVuc.Properties.DisplayMember = "TEN";
                cbxKhuVuc.Properties.ValueMember = "ID";
                cbxKhuVuc.ItemIndex = 0;

                // Load textbox loại mặt hàng
                txtLoaiHang.Text = db.LOAIHANGs.ToList().FirstOrDefault().TEN;
                txtMatHang.Text = db.MATHANGs.ToList().FirstOrDefault().TEN;

                // danh dau ID
                txtLoaiHang.Tag = db.LOAIHANGs.ToList().FirstOrDefault().ID;
                txtMatHang.Tag = db.LOAIHANGs.ToList().FirstOrDefault().ID;

                LoadMatHang((int)txtLoaiHang.Tag);
                LoadEmptyTable();
            }
            catch { }
        }
        private void LoadLoaiHang()
        {
            pnlLoaiHang.Controls.Clear();
            List<LOAIHANG> listLH = db.LOAIHANGs.ToList();
            foreach (LOAIHANG item in listLH)
            {
                Button btnLH = new Button() { Width = 130, Height = 60 };
                btnLH.Text = item.TEN;
                btnLH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnLH.Tag = item;
                btnLH.FlatStyle = FlatStyle.Standard;
                btnLH.BackColor = Color.LightCoral;
                btnLH.Click += BtnLH_Click;
                pnlLoaiHang.Controls.Add(btnLH);
            }
        }

        private void LoadMatHang(int id)
        {
            pnlMatHang.Controls.Clear();
            List<MATHANG> listMH = db.MATHANGs.Where(p => p.LOAIHANGID == id).ToList();
            foreach(var item in listMH)
            {
                ucMatHang uc = new ucMatHang(item, ucMatHang_Click);
                pnlMatHang.Controls.Add(uc);  
            }
            txtMatHang.Tag = listMH.FirstOrDefault().ID;
            txtMatHang.Text = listMH.FirstOrDefault().TEN;
        }

        private void BtnLH_Click(object sender, EventArgs e)
        {
            txtLoaiHang.Text = ((sender as Button)).Text;
            LoadMatHang(((sender as Button).Tag as LOAIHANG).ID);
        }
        private void ucMatHang_Click(object sender, EventArgs e)
        {
            PictureBox pn = sender as PictureBox;
            txtMatHang.Text = (pn.Tag as MATHANG).TEN.ToString();
            txtMatHang.Tag = (pn.Tag as MATHANG).ID;
        }
        private void ucBanAnClick(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            Binding((int)(btn.Tag as BANAN).ID);
            txtTrangThai.Text = ((int)(btn.Tag as BANAN).TRANGTHAI == 1) ? "Có Khách" : "Trống";
        }

        private void UpdateDsBanAn()
        {
            try
            {
                foreach (var item in panelDsBanAn.Controls)
                {
                    ucBanAn uc = item as ucBanAn;
                    uc.Refresh();
                }
            }
            catch { }
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            if (db.MATHANGs.ToList().Count == 0)
            {
                MessageBox.Show("Danh sách mặt hàng đang trống\nVui lòng thêm mặt hàng ở mục quản trị",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
            }

            if (db.BANANs.ToList().Count == 0)
            {
                MessageBox.Show("Danh sách bàn ăn đang trống\nVui lòng thêm bàn ăn ở mục quản trị",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Hide();
            }

            LoadInitControl();
            ClearControl();
            LoadDanhSachBanAn();
            LoadLoaiHang();
        }
        #endregion

        #region Hàm phụ trợ
        private void Binding(int ID)
        {
            try
            {
                BANAN ba = db.BANANs.Where(p => p.ID == ID).FirstOrDefault();
                if (ba == null) return;

                IDBanAn = ID;
                table = ba;
                txtTenBanAn.Text = ba.TEN + " : ";

                LoadEmptyTable();
                ClearControl();
                if (ba.TRANGTHAI == 0) return;

                if (ba.TRANGTHAI == 1)
                {
                    int idHoaDon = (int)ba.HOADONBANID;
                    LoadDanhSachHoaDon(idHoaDon);
                    HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == ba.HOADONBANID).FirstOrDefault();
                    txtTongTien.Text = ((int)hd.TONGTIEN).ToString("N0");
                }
            }
            catch { }
        }
        private void ClearControl()
        {
            txtTongTien.Text = "0";
            dgvHoaDonMain.DataSource = null;
            txtTrangThai.Text = "Trống";
        }
        #endregion

        #region Sự kiện
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            /// kiểm tra đã có bàn ăn nào được chọn chưa
            if (IDBanAn == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra xem bàn ăn là bàn đã có khách hay chưa có khách
            BANAN banan = db.BANANs.Where(p => p.ID == IDBanAn).FirstOrDefault();
            if (banan.HOADONBANID == null)
            {
                MessageBox.Show("Bàn ăn không có khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra lại xem đã muốn thanh toán chưa
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn thanh toán và in hóa đơn?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Question);

            if (rs == DialogResult.Cancel) return;

            try
            {


                if (rs == DialogResult.OK)
                {
                    /// xuất report hóa đơn
                    int ID = (int)banan.HOADONBANID;
                    HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == ID).FirstOrDefault();
                    int khuyenmai = (int)txtKhuyenMai.Value;

                    FrmRpHoaDon form = new FrmRpHoaDon(hd, khuyenmai);
                    form.ShowDialog();

                    hd.KHUYENMAI = khuyenmai;
                    db.SaveChanges();

                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                banan.TRANGTHAI = 0;
                banan.HOADONBANID = null;
                db.SaveChanges();

                UpdateDsBanAn();
                Binding(banan.ID);
            }
            catch
            {
                MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            try
            {
                /// Kiểm tra bàn ăn xem đã được chọn chưa
                if (IDBanAn == 0)
                {
                    MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                int idMatHang = (int)txtMatHang.Tag;
                MATHANG mathang = db.MATHANGs.Where(p => p.ID == idMatHang).FirstOrDefault();
                int SoLuongGM = (int)txtGMSoLuong.Value;
                int SoLuong = (int)db.KHOes.Where(p => p.MATHANGID == idMatHang).FirstOrDefault().SOLUONG;

                // Kiểm tra kho
                if (SoLuong < SoLuongGM)
                {
                    MessageBox.Show("Không đủ hàng (" + SoLuong + ")",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                /// Trừ số lượng trong kho
                KHO kho = db.KHOes.Where(p => p.MATHANGID == idMatHang).FirstOrDefault();
                kho.SOLUONG -= SoLuongGM;

                if (table.HOADONBANID == null)
                {
                    // nếu bàn ăn này chưa chứa hóa đơn nào
                    HOADONBAN hd = new HOADONBAN();
                    hd.NGAYBAN = DateTime.Now;
                    hd.TONGTIEN = 0;
                    hd.NHANVIENID = Provider.nhanvien.ID;
                    hd.KHUYENMAI = 0;
                    db.HOADONBANs.Add(hd);
                    db.SaveChanges();

                    table.TRANGTHAI = 1;
                    table.HOADONBANID = hd.ID;
                    db.SaveChanges();

                    CHITIETHDB chitiet = new CHITIETHDB();
                    chitiet.HOADONBANID = hd.ID;
                    chitiet.SOLUONG = SoLuongGM;
                    chitiet.MATHANGID = mathang.ID;
                    chitiet.DONGIA = mathang.GIABAN;
                    chitiet.THANHTIEN = chitiet.DONGIA * chitiet.SOLUONG;
                    db.CHITIETHDBs.Add(chitiet);
                    hd.TONGTIEN = chitiet.THANHTIEN;
                    db.SaveChanges();
                }
                else
                {
                    // nếu bàn ăn này đã chứa hóa đơn
                    HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == table.HOADONBANID).FirstOrDefault();

                    var listChiTiet = db.CHITIETHDBs.Where(p => p.HOADONBANID == hd.ID).ToList();
                    CHITIETHDB chitiet;
                    chitiet = listChiTiet.Where(p => p.MATHANGID == mathang.ID).FirstOrDefault();

                    if (chitiet == null)
                    {
                        /// Nếu sản phẩm này chưa từng được thêm vào hóa đơn
                        chitiet = new CHITIETHDB();
                        chitiet.HOADONBANID = hd.ID;
                        chitiet.SOLUONG = SoLuongGM;
                        chitiet.MATHANGID = mathang.ID;
                        chitiet.DONGIA = mathang.GIABAN;
                        chitiet.THANHTIEN = chitiet.DONGIA * chitiet.SOLUONG;
                        db.CHITIETHDBs.Add(chitiet);

                        hd.TONGTIEN += chitiet.THANHTIEN;

                        db.SaveChanges();
                    }
                    else
                    {
                        /// Nếu sản phẩm này đã từng được thêm thì tăng số lượng
                        chitiet.SOLUONG += SoLuongGM;
                        chitiet.THANHTIEN = SoLuongGM * chitiet.DONGIA;
                        hd.TONGTIEN += chitiet.THANHTIEN;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                UpdateDsBanAn();
                Binding(IDBanAn);
            }
        }

        private void cbxKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachBanAn();
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (IDBanAn == 0)
            {
                MessageBox.Show("Chưa có bàn ăn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra xem bàn ăn là bàn đã có khách hay chưa có khách
            BANAN banan = db.BANANs.Where(p => p.ID == IDBanAn).FirstOrDefault();
            if (banan.HOADONBANID == null)
            {
                MessageBox.Show("Bàn ăn không có khách",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int idBanAnMoi = (int)cbxCBAN.EditValue;
            BANAN bananmoi = db.BANANs.Where(p => p.ID == idBanAnMoi).FirstOrDefault();

            bananmoi.TRANGTHAI = 1;
            bananmoi.HOADONBANID = banan.HOADONBANID;
            banan.TRANGTHAI = 0;
            banan.HOADONBANID = null;

            try
            {
                db.SaveChanges();
                IDBanAn = idBanAnMoi;
                Binding(idBanAnMoi);

                UpdateDsBanAn();

                MessageBox.Show("Chuyển bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Chuyển bản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = (int)dgvHoaDon.GetFocusedRowCellValue("ID");
            }
            catch
            {
                MessageBox.Show("Chưa có mặt hàng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HOADONBAN hd = db.HOADONBANs.Where(p => p.ID == table.HOADONBANID).FirstOrDefault();
            CHITIETHDB ct = db.CHITIETHDBs.Where(p => p.ID == id).FirstOrDefault();

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa món ?",
                                              "Thông báo",
                                              MessageBoxButtons.OKCancel,
                                              MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            try
            {
                hd.TONGTIEN -= ct.DONGIA * ct.SOLUONG;

                KHO kho = db.KHOes.Where(p => p.MATHANGID == ct.MATHANGID).FirstOrDefault();
                kho.SOLUONG += ct.SOLUONG;

                db.CHITIETHDBs.Remove(ct);
                db.SaveChanges();

                int cnt = db.CHITIETHDBs.Where(p => p.HOADONBANID == hd.ID).ToList().Count;
                if (cnt == 0)
                {
                    BANAN ba = db.BANANs.Where(p => p.HOADONBANID == table.HOADONBANID).FirstOrDefault();
                    ba.HOADONBANID = null;
                    ba.TRANGTHAI = 0;
                    db.SaveChanges();

                    table = ba;
                    db.HOADONBANs.Remove(hd);
                    db.SaveChanges();                   
                    UpdateDsBanAn();
                }
                MessageBox.Show("Xóa món thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa món thất bại\n" + ex.Message,
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Binding(IDBanAn);
            }      
        }
    }
}
