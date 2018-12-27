namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBAN")]
    public partial class HOADONBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBAN()
        {
            BANANs = new HashSet<BANAN>();
            CHITIETHDBs = new HashSet<CHITIETHDB>();
        }
        public int ID { get; set; }

        public int? NHANVIENID { get; set; }

        public DateTime? NGAYBAN { get; set; }

        public int? TONGTIEN { get; set; }

        public int? KHUYENMAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANAN> BANANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHDB> CHITIETHDBs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
