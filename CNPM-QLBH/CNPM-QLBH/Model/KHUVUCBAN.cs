namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUVUCBAN")]
    public partial class KHUVUCBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUVUCBAN()
        {
            BANANs = new HashSet<BANAN>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string TEN { get; set; }

        [StringLength(100)]
        public string VITRI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANAN> BANANs { get; set; }
    }
}
