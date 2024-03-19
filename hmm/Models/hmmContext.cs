using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hmm.Models
{
    public partial class hmmContext : DbContext
    {
        public hmmContext()
        {
        }

        public hmmContext(DbContextOptions<hmmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Infor> Infors { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ZDUNG2308\\SQLEXPRESS;Database=hmm;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Infor>(entity =>
            {
                entity.HasKey(e => e.Usn)
                    .HasName("PK__infor__DD778C35A5FC0824");

                entity.ToTable("infor");

                entity.Property(e => e.Usn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usn");

                entity.Property(e => e.Dc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dc");

                entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("hoten");

                entity.Property(e => e.Job)
                    .HasMaxLength(50)
                    .HasColumnName("job");

                entity.Property(e => e.Ngsinh)
                    .HasColumnType("date")
                    .HasColumnName("ngsinh");

                entity.Property(e => e.School)
                    .HasMaxLength(100)
                    .HasColumnName("school");

                entity.Property(e => e.Tuoi).HasColumnName("tuoi");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.Usn)
                    .HasName("PK__taikhoan__DD778C352EE5F967");

                entity.ToTable("taikhoan");

                entity.Property(e => e.Usn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usn");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.HasOne(d => d.UsnNavigation)
                    .WithOne(p => p.Taikhoan)
                    .HasForeignKey<Taikhoan>(d => d.Usn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
