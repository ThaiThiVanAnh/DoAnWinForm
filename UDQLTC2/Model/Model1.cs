using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UDQLTC.DAL.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model16")
        {
        }

        public virtual DbSet<DANHMUC_CHI> DANHMUC_CHI { get; set; }
        public virtual DbSet<DANHMUC_THU> DANHMUC_THU { get; set; }
        public virtual DbSet<KHOAN_CHI> KHOAN_CHI { get; set; }
        public virtual DbSet<KHOAN_THU> KHOAN_THU { get; set; }
        public virtual DbSet<LIEN_KET> LIEN_KET { get; set; }
        public virtual DbSet<LOAI_DANHMUC> LOAI_DANHMUC { get; set; }
        public virtual DbSet<LOAI_MT> LOAI_MT { get; set; }
        public virtual DbSet<MUC_TIEU> MUC_TIEU { get; set; }
        public virtual DbSet<PHAN_QUYEN> PHAN_QUYEN { get; set; }
        public virtual DbSet<TAI_KHOAN> TAI_KHOAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KHOAN_CHI>()
                .Property(e => e.SO_TIEN)
                .HasPrecision(10, 2);

            modelBuilder.Entity<KHOAN_THU>()
                .Property(e => e.SO_TIEN)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MUC_TIEU>()
                .Property(e => e.TEN_MT)
                .IsUnicode(false);

            modelBuilder.Entity<MUC_TIEU>()
                .Property(e => e.SOTIEN_MT)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PHAN_QUYEN>()
                .Property(e => e.TEN_PQ)
                .IsUnicode(false);

            modelBuilder.Entity<TAI_KHOAN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TAI_KHOAN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TAI_KHOAN>()
                .Property(e => e.STD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAI_KHOAN>()
                .HasMany(e => e.LIEN_KET)
                .WithOptional(e => e.TAI_KHOAN)
                .HasForeignKey(e => e.ID_TK);

            modelBuilder.Entity<TAI_KHOAN>()
                .HasMany(e => e.LIEN_KET1)
                .WithOptional(e => e.TAI_KHOAN1)
                .HasForeignKey(e => e.LINKED_USER_ID);
        }
    }
}
