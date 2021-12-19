using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GI.FI01.Models
{
    public partial class Winterhack123Context : DbContext
    {
        public Winterhack123Context()
        {
        }

        public Winterhack123Context(DbContextOptions<Winterhack123Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Smartphones> Smartphones { get; set; }
        public virtual DbSet<Smartwatchs> Smartwatchs { get; set; }
        public virtual DbSet<Tablets> Tablets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source =tcp:winterhackgifi120.database.windows.net,1433;Initial Catalog=Winterhack123;Persist Security Info=False;User ID=winterhack120;Password=Winter120;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smartphones>(entity =>
            {
                entity.HasKey(e => e.SmartphoneId)
                    .HasName("PK__Smartpho__ECE5BAB2E9792D23");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Shop)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Smartwatchs>(entity =>
            {
                entity.HasKey(e => e.SmartWid)
                    .HasName("PK__Smartwat__9AB2EB12505B9A2D");

                entity.Property(e => e.SmartWid).HasColumnName("SmartWId");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Shop)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Tablets>(entity =>
            {
                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Shop)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
