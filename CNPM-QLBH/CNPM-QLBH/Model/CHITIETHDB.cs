namespace CNPM_QLBH.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHDB")]
    public partial class CHITIETHDB
    {
        public int ID { get; set; }

        public int? MATHANGID { get; set; }

        public int? DONGIA { get; set; }

        public int? SOLUONG { get; set; }

        public int? THANHTIEN { get; set; }

        public int? HOADONBANID { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual MATHANG MATHANG { get; set; }
    }
}
