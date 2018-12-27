using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CNPM_QLBH.Model;

namespace CNPM_QLBH
{
    class Provider
    {
        #region Load
        public static Model.CSDL db = new Model.CSDL();

        public static void Reload()
        {
            try
            {
                var context = ((IObjectContextAdapter)db).ObjectContext;
                var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                           EntityState.Added
                                                           | EntityState.Deleted
                                                           | EntityState.Modified
                                                           | EntityState.Unchanged)
                                          where entry.EntityKey != null
                                          select entry.Entity).ToList();

                context.Refresh(RefreshMode.StoreWins, refreshableObjects);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Method

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static int SoLuong(MATHANG a, DateTime batdau, DateTime ketthuc)
        {
            int ans = (
                        from chitiet in db.CHITIETHDBs.Where(p => p.MATHANGID == a.ID).ToList()
                        from hoadon in db.HOADONBANs.Where(p => p.ID == chitiet.HOADONBANID && p.NGAYBAN >= batdau && p.NGAYBAN <= ketthuc).ToList()
                        select chitiet
                      )
                      .ToList()
                      .Sum(p => (int)p.SOLUONG);

            return ans;
        }
        #endregion

        #region Lưu tạm 
        public static NHANVIEN NhanVien = db.NHANVIENs.FirstOrDefault();
        public static PHIEUNHAP PhieuNhap = new PHIEUNHAP();
        public static List<Report_Viewer.HoaDonData> data = new List<Report_Viewer.HoaDonData>();
        #endregion

    }
}
