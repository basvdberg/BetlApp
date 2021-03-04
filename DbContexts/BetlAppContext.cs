using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BetlApp.Data;

#nullable disable

namespace BetlApp.DbContexts
{
    public partial class BetlAppContext : DbContext
    {
        public BetlAppContext()
        {
        }

        public BetlAppContext(DbContextOptions<BetlAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ObjDef> ObjDefs { get; set; }
        public virtual DbSet<ObjType> ObjTypes { get; set; }
        public virtual DbSet<ServerType> ServerTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=betlApp;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ObjDef>(entity =>
            {
                entity.ToTable("Obj_def");

                entity.Property(e => e.Id).HasColumnName("obj_def_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ServerTypeId)
                    .HasColumnName("server_type_id")
                    .HasDefaultValueSql("((10))");

                entity.HasOne(d => d.ObjType)
                    .WithMany(p => p.ObjDefs)
                    .HasForeignKey(d => d.ObjTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_def_h_Obj_type");

                entity.HasOne(d => d.ServerType)
                    .WithMany(p => p.ObjDefs)
                    .HasForeignKey(d => d.ServerTypeId)
                    .HasConstraintName("FK_Obj_def_h_Server_type");
            });

            modelBuilder.Entity<ObjType>(entity =>
            {
                entity.ToTable("Obj_type", "static");

                entity.Property(e => e.ObjTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("obj_type_id");

                entity.Property(e => e.ObjType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.ObjTypeLevel).HasColumnName("obj_type_level");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<ServerType>(entity =>
            {
                entity.ToTable("Server_type", "static");

                entity.Property(e => e.ServerTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("server_type_id");

                entity.Property(e => e.Compatibility)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("compatibility");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.ServerType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("server_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
