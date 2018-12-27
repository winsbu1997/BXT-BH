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
using System.Windows.Forms.DataVisualization.Charting;

namespace CNPM_QLBH.GUI
{
    public partial class ThongKeMonAn : UserControl
    {
        private CSDL db = Provider.db;
        public ThongKeMonAn()
        {
            InitializeComponent();
            Provider.Reload();
        }

        #region LoadForm
        private void Loaddgv()
        {
            int i = 0;
            var listMatHang = (from mathang in db.MATHANGs.ToList()
                               select new
                                         {
                                             STT = ++i,
                                             MatHang = mathang.TEN,
                                             DonGia = mathang.GIABAN,
                                             SoLuong = Provider.SoLuong(mathang, dateBatDau.DateTime, dateKetThuc.DateTime),
                                             ThanhTien = ((int)mathang.GIABAN * Provider.SoLuong(mathang, dateBatDau.DateTime, dateKetThuc.DateTime)).ToString("N0"),
                                             gt = ((int)mathang.GIABAN * Provider.SoLuong(mathang, dateBatDau.DateTime, dateKetThuc.DateTime))
                                         })
                                         .OrderByDescending(p => p.gt)
                                        .ToList();
            dgvMatHangMain.DataSource = listMatHang;

            chartThongKe.DataSource = listMatHang.Where(p => p.gt > 0).ToList();
            chartThongKe.Series[0].XValueMember = "MatHang";
            chartThongKe.Series[0].XValueType = ChartValueType.String;
            chartThongKe.Series[0].YValueMembers = "ThanhTien";
            chartThongKe.Series[0].YValueType = ChartValueType.Int32;

        }
        private void ThongKeMonAn_Load(object sender, EventArgs e)
        {
            dateBatDau.DateTime = DateTime.Now.AddDays(-30);
            dateKetThuc.DateTime = DateTime.Now;
            Loaddgv();
        }

        #endregion

        #region Event
        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            Loaddgv();
        }
        #endregion
    }
}
