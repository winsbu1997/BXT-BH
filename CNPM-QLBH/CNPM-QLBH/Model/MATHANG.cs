namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATHANG")]
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            CHITIETHDBs = new HashSet<CHITIETHDB>();
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
            KHOes = new HashSet<KHO>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string TEN { get; set; }

        [StringLength(100)]
        public string DONVITINH { get; set; }

        public int? GIABAN { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        public int? LOAIHANGID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHDB> CHITIETHDBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO> KHOes { get; set; }

        public virtual LOAIHANG LOAIHANG { get; set; }
    }
}
