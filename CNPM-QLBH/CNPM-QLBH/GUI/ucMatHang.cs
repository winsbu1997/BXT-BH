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
    public partial class ucMatHang : UserControl
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMatHang));
        private CSDL db = Provider.db;
        private MATHANG mathang = new MATHANG();

        public ucMatHang(MATHANG mh, EventHandler e)
        {
            InitializeComponent();
            Provider.Reload();
            mathang = mh;

            ptbAnh.Click += e;
            ptbAnh.Tag = mh;
        }
        #region LoadForm
        private void ucMatHang_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenMatHang.Text = mathang.TEN;
                txtGiaBan.Text = ((int)mathang.GIABAN).ToString("N0") + " vnđ";
                ptbAnh.Image = Provider.byteArrayToImage(mathang.HINHANH);
            }
            catch { }
        }
        #endregion
    }
}
