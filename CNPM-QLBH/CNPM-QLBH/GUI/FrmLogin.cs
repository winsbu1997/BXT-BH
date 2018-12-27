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
namespace CNPM_QLBH.GUI
{
    public partial class FrmLogin : Form
    {
        private CSDL db = Provider.db;
        public FrmLogin()
        {
            InitializeComponent();
            Provider.Reload();
        }
        private bool Check(string taikhoan, string matkhau)
        {
            if (taikhoan == "")
            {
                MessageBox.Show("Tài khoản không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (matkhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (Check(taikhoan,matkhau) == false) return;
            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan && p.MATKHAU == matkhau).ToList().Count;
            if (cnt == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Provider.NhanVien = db.NHANVIENs.Where(p => p.TAIKHOAN == taikhoan && p.MATKHAU == matkhau).FirstOrDefault();

            FrmMain form = new FrmMain();
            this.Hide();
            form.ShowDialog();
            this.Show();
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            this.Focus();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
