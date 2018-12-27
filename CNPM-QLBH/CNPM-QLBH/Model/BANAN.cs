namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANAN")]
    public partial class BANAN
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TEN { get; set; }

        public int? SOCHO { get; set; }

        [StringLength(100)]
        public string VITRI { get; set; }

        public int? TRANGTHAI { get; set; }

        public int? HOADONBANID { get; set; }

        public int? KHUVUCBANID { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual KHUVUCBAN KHUVUCBAN { get; set; }
    }
}
