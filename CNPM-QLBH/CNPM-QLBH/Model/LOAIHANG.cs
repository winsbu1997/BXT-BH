namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHANG")]
    public partial class LOAIHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHANG()
        {
            MATHANGs = new HashSet<MATHANG>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string TEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
    }
}
