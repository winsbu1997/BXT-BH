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
    public partial class FrmDoiMatKhau : Form
    {
        private CSDL db = Provider.db;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
            Provider.Reload();
        }

        private bool Check()
        {
            NHANVIEN nv = Provider.NhanVien;
            if (txtMatKhauCu.Text != nv.MATKHAU)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtXacNhan.Text != txtMatKhauMoi.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = Provider.NhanVien;
            if (Check() == false) return;
            try
            {
                nv.MATKHAU = txtMatKhauMoi.Text;
                db.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
