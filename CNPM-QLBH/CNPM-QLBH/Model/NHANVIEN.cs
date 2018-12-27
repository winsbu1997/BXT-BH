namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONBANs = new HashSet<HOADONBAN>();
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string TEN { get; set; }

        public int? CHUCVU { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        [StringLength(100)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string QUEQUAN { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        [StringLength(100)]
        public string TAIKHOAN { get; set; }

        [StringLength(100)]
        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
