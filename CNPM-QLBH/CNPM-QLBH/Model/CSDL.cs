namespace CNPM_QLBH.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CSDL : DbContext
    {
        public CSDL()
            : base("name=CSDL")
        {
        }

        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<CHITIETHDB> CHITIETHDBs { get; set; }
        public virtual DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<KHUVUCBAN> KHUVUCBANs { get; set; }
        public virtual DbSet<LOAIHANG> LOAIHANGs { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADONBAN>()
                .HasMany(e => e.CHITIETHDBs)
                .WithRequired(e => e.HOADONBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CHITIETNHAPs)
                .WithRequired(e => e.PHIEUNHAP)
                .WillCascadeOnDelete(false);

        }
    }
}
