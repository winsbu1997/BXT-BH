using CNPM_QLBH.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CNPM_QLBH
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = Provider.NhanVien.TAIKHOAN;
            if (Provider.NhanVien.CHUCVU == 1) rbQuanLy.Visible = false;
            else rbQuanLy.Visible = true;

            panelMain.Controls.Clear();
            BanHang uc = new BanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.NhapHang uc = new GUI.NhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            this.Close();
            Application.Restart();    
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau();
            form.ShowDialog();
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.BanHang uc = new GUI.BanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.ThongTinKho uc = new GUI.ThongTinKho();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void btnQLBanAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.QuanLyBanAn uc = new GUI.QuanLyBanAn();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.QuanLyKhuVucBan uc = new GUI.QuanLyKhuVucBan();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnTKNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.ThongKeNhapHang uc = new GUI.ThongKeNhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnTKBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.ThongKeBanHang uc = new GUI.ThongKeBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnQLNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.QuanLiNhanVien uc = new GUI.QuanLiNhanVien();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnQLThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.QuanLyThucDon uc = new GUI.QuanLyThucDon();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void btnTKMonAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            GUI.ThongKeMonAn uc = new GUI.ThongKeMonAn();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
    }
}
