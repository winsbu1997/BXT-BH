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
    public partial class ThongTinKho : UserControl
    {
        private CSDL db = Provider.db;
        public ThongTinKho()
        {
            InitializeComponent();
            Provider.Reload();
        }

        #region LoadForm
        private void LoadDanhSachMatHang()
        {
            string keyWord = txtTimKiem.Text.ToUpper();
            int i = 0;
            var listMatHang = db.MATHANGs.ToList()
                              .Select(p => new
                              {
                                  ID = p.ID,
                                  Ten = p.TEN,
                                  DonViTinh = p.DONVITINH,
                                  GiaBan = ((int)p.GIABAN).ToString("N0") + " vnđ",
                                  SoLuong = db.KHOes.Where(z => z.MATHANGID == p.ID).FirstOrDefault().SOLUONG,
                                  gt = p.GIABAN
                              })
                              .ToList();

            if (rdSoLuong.Checked) listMatHang = listMatHang.OrderByDescending(p => p.SoLuong).ToList();
            if (rdTenMatHang.Checked) listMatHang = listMatHang.OrderBy(p => p.Ten).ToList();
            if (rdGiaBan.Checked) listMatHang = listMatHang.OrderByDescending(p => p.gt).ToList();

            dgvMATHANGMain.DataSource = listMatHang.ToList()
                                        .Where(p => p.Ten.ToUpper().Contains(keyWord) || p.DonViTinh.ToUpper().Contains(keyWord) || p.GiaBan.ToUpper().Contains(keyWord))
                                        .Select(p => new
                                        {
                                            ID = p.ID,
                                            STT = ++i,
                                            Ten = p.Ten,
                                            DonViTinh = p.DonViTinh,
                                            GiaBan = p.GiaBan,
                                            SoLuong = p.SoLuong
                                        }).ToList();
        }

        private void Load_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSachMatHang();
        }

        #endregion

        #region Sự kiện
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDanhSachMatHang();
        }

        private void ThongTinKho_Load(object sender, EventArgs e)
        {
            LoadDanhSachMatHang();
        }
        #endregion
    }
}
