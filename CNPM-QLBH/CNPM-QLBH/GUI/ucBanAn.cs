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
    public partial class ucBanAn : UserControl
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanAn));
        private BANAN ban = new BANAN();
            public ucBanAn(BANAN ba, EventHandler e)
        {
            InitializeComponent();
            Provider.Reload();
            ban = ba;

            btnBanAn.Click += e;
            btnBanAn.Tag = ba;
        }
        #region LoadForm
        private void LoadBanAn()
        {
            btnBanAn.Text = ban.TEN;

            if (ban.TRANGTHAI == 1)
            {
                btnBanAn.ForeColor = Color.Red;
            }
            else
            {
                btnBanAn.ForeColor = Color.ForestGreen;
            }
        }
        private void ucBanAn_Load(object sender, EventArgs e)
        {
            LoadBanAn();
        }
        public void Refresh()
        {
            LoadBanAn();
        }
        #endregion
    }
}
