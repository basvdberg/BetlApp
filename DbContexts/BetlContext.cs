using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BetlApp.Data;

#nullable disable

namespace BetlApp.DbContexts
{
    public partial class BetlContext : DbContext
    {
        public BetlContext()
        {
        }

        public BetlContext(DbContextOptions<BetlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<BatchExt> BatchExts { get; set; }
        public virtual DbSet<CacheUserDatum> CacheUserData { get; set; }
        public virtual DbSet<Col> Cols { get; set; }
        public virtual DbSet<ColDef> ColDefs { get; set; }
        public virtual DbSet<ColExt> ColExts { get; set; }
        public virtual DbSet<ColExtUnpivot> ColExtUnpivots { get; set; }
        public virtual DbSet<ColH> ColHs { get; set; }
        public virtual DbSet<ColMap> ColMaps { get; set; }
        public virtual DbSet<ColMapTransform> ColMapTransforms { get; set; }
        public virtual DbSet<Column> Columns { get; set; }
        public virtual DbSet<ColumnEnriched> ColumnEnricheds { get; set; }
        public virtual DbSet<ColumnEnrichedExt> ColumnEnrichedExts { get; set; }
        public virtual DbSet<ColumnType> ColumnTypes { get; set; }
        public virtual DbSet<DataDic> DataDics { get; set; }
        public virtual DbSet<DepType> DepTypes { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobExt> JobExts { get; set; }
        public virtual DbSet<JobSchedule> JobSchedules { get; set; }
        public virtual DbSet<JobStep> JobSteps { get; set; }
        public virtual DbSet<JobStepExt> JobStepExts { get; set; }
        public virtual DbSet<JoinType> JoinTypes { get; set; }
        public virtual DbSet<KeyDomain> KeyDomains { get; set; }
        public virtual DbSet<LogLevel> LogLevels { get; set; }
        public virtual DbSet<LogType> LogTypes { get; set; }
        public virtual DbSet<Logging> Loggings { get; set; }
        public virtual DbSet<LoggingExt> LoggingExts { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<Obj> Objs { get; set; }
        public virtual DbSet<ObjDef> ObjDefs { get; set; }
        public virtual DbSet<ObjDep> ObjDeps { get; set; }
        public virtual DbSet<ObjDepExt> ObjDepExts { get; set; }
        public virtual DbSet<ObjExt> ObjExts { get; set; }
        public virtual DbSet<ObjExtAll> ObjExtAlls { get; set; }
        public virtual DbSet<ObjExtAllUnpivot> ObjExtAllUnpivots { get; set; }
        public virtual DbSet<ObjExtUnpivot> ObjExtUnpivots { get; set; }
        public virtual DbSet<ObjMap> ObjMaps { get; set; }
        public virtual DbSet<ObjMapTransform> ObjMapTransforms { get; set; }
        public virtual DbSet<ObjTransfer> ObjTransfers { get; set; }
        public virtual DbSet<ObjTreeIdwHubCol> ObjTreeIdwHubCols { get; set; }
        public virtual DbSet<ObjTreeIdwHubsNatPkeySize> ObjTreeIdwHubsNatPkeySizes { get; set; }
        public virtual DbSet<ObjTreeIdwTable> ObjTreeIdwTables { get; set; }
        public virtual DbSet<ObjTreeIdwTableColsBasic> ObjTreeIdwTableColsBasics { get; set; }
        public virtual DbSet<ObjTreeIdwView> ObjTreeIdwViews { get; set; }
        public virtual DbSet<ObjTreeRdwTable> ObjTreeRdwTables { get; set; }
        public virtual DbSet<ObjTreeRdwView> ObjTreeRdwViews { get; set; }
        public virtual DbSet<ObjTreeStagingTable> ObjTreeStagingTables { get; set; }
        public virtual DbSet<ObjTreeStagingView> ObjTreeStagingViews { get; set; }
        public virtual DbSet<ObjType> ObjTypes { get; set; }
        public virtual DbSet<Prefix> Prefixes { get; set; }
        public virtual DbSet<PropExt> PropExts { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<RuleMapping> RuleMappings { get; set; }
        public virtual DbSet<ServerType> ServerTypes { get; set; }
        public virtual DbSet<Stack> Stacks { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<TransferExt> TransferExts { get; set; }
        public virtual DbSet<Transform> Transforms { get; set; }
        public virtual DbSet<BetlApp.Data.Version> Versions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         /*   if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=betl;Trusted_Connection=True;MultipleActiveResultSets=true");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.BatchEndDt)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_end_dt");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(128)
                    .HasColumnName("batch_name");

                entity.Property(e => e.BatchSeq).HasColumnName("batch_seq");

                entity.Property(e => e.BatchStartDt)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_start_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContinueBatch)
                    .HasColumnName("continue_batch")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecHost)
                    .HasMaxLength(128)
                    .HasColumnName("exec_host")
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.ExecServer)
                    .HasMaxLength(128)
                    .HasColumnName("exec_server")
                    .HasDefaultValueSql("(@@servername)");

                entity.Property(e => e.ExecUser)
                    .HasMaxLength(128)
                    .HasColumnName("exec_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Guid)
                    .HasMaxLength(255)
                    .HasColumnName("guid");

                entity.Property(e => e.LastErrorId)
                    .HasColumnName("last_error_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ParentBatchId).HasColumnName("parent_batch_id");

                entity.Property(e => e.PrevBatchId)
                    .HasColumnName("prev_batch_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.LastError)
                    .WithMany(p => p.Batches)
                    .HasForeignKey(d => d.LastErrorId)
                    .HasConstraintName("FK_Batch_Error");

                entity.HasOne(d => d.PrevBatch)
                    .WithMany(p => p.InversePrevBatch)
                    .HasForeignKey(d => d.PrevBatchId)
                    .HasConstraintName("FK_Batch_Batch");
            });

            modelBuilder.Entity<BatchExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Batch_ext");

                entity.Property(e => e.BatchEndDt)
                    .HasPrecision(3)
                    .HasColumnName("batch_end_dt");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(128)
                    .HasColumnName("batch_name");

                entity.Property(e => e.BatchStartDt)
                    .HasPrecision(3)
                    .HasColumnName("batch_start_dt");

                entity.Property(e => e.BatchStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_status");

                entity.Property(e => e.PrevBatchEndDt)
                    .HasPrecision(3)
                    .HasColumnName("prev_batch_end_dt");

                entity.Property(e => e.PrevBatchId).HasColumnName("prev_batch_id");

                entity.Property(e => e.PrevBatchStartDt)
                    .HasPrecision(3)
                    .HasColumnName("prev_batch_start_dt");

                entity.Property(e => e.PrevBatchStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prev_batch_status");
            });

            modelBuilder.Entity<CacheUserDatum>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Cache_1");

                entity.ToTable("Cache_user_data");

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .HasColumnName("user_name");

                entity.Property(e => e.ExecSql).HasColumnName("exec_sql");

                entity.Property(e => e.ExpirationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("expiration_dt");

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(128)
                    .HasColumnName("log_level");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Col>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Col");

                entity.Property(e => e.Chksum)
                    .HasMaxLength(20)
                    .HasColumnName("_chksum");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.EffDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_eff_dt");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PartOfUniqueIndex).HasColumnName("part_of_unique_index");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user");

                entity.Property(e => e.TransferId).HasColumnName("_transfer_id");
            });

            modelBuilder.Entity<ColDef>(entity =>
            {
                entity.ToTable("Col_def");

                entity.Property(e => e.ColDefId).HasColumnName("col_def_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjDefId).HasColumnName("obj_def_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PartOfUniqueIndex).HasColumnName("part_of_unique_index");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.ObjDef)
                    .WithMany(p => p.ColDefs)
                    .HasForeignKey(d => d.ObjDefId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Col_def_Obj_def");
            });

            modelBuilder.Entity<ColExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Col_ext");

                entity.Property(e => e.Chksum)
                    .HasMaxLength(20)
                    .HasColumnName("_chksum");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("column_type");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PartOfUniqueIndex).HasColumnName("part_of_unique_index");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.RequestCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_create_dt");

                entity.Property(e => e.RequestDeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_delete_dt");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ColExtUnpivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Col_ext_unpivot");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("_name");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .HasColumnName("_value");
            });

            modelBuilder.Entity<ColH>(entity =>
            {
                entity.HasKey(e => new { e.ColumnId, e.EffDt })
                    .HasName("PK__Hst_column");

                entity.ToTable("Col_h");

                entity.Property(e => e.ColumnId)
                    .HasColumnName("column_id")
                    .HasDefaultValueSql("(NEXT VALUE FOR [seq_col_hist])");

                entity.Property(e => e.EffDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_eff_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Chksum)
                    .HasMaxLength(20)
                    .HasColumnName("_chksum");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PartOfUniqueIndex).HasColumnName("part_of_unique_index");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.TransferId).HasColumnName("_transfer_id");

                entity.HasOne(d => d.ColumnType)
                    .WithMany(p => p.ColHs)
                    .HasForeignKey(d => d.ColumnTypeId)
                    .HasConstraintName("FK_Col_hist_Column_type");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.ColHs)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Col_h_Obj");
            });

            modelBuilder.Entity<ColMap>(entity =>
            {
                entity.ToTable("Col_map");

                entity.Property(e => e.ColMapId).HasColumnName("col_map_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.ColDefId).HasColumnName("col_def_id");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.JoinTypeId).HasColumnName("join_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<ColMapTransform>(entity =>
            {
                entity.HasKey(e => new { e.ColMapId, e.TransformId });

                entity.ToTable("Col_map_transform");

                entity.Property(e => e.ColMapId).HasColumnName("col_map_id");

                entity.Property(e => e.TransformId).HasColumnName("transform_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.ColMap)
                    .WithMany(p => p.ColMapTransforms)
                    .HasForeignKey(d => d.ColMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Col_map_transform_cOl_map_id");

                entity.HasOne(d => d.Transform)
                    .WithMany(p => p.ColMapTransforms)
                    .HasForeignKey(d => d.TransformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Col_map_transform_id");
            });

            modelBuilder.Entity<Column>(entity =>
            {
                entity.ToTable("Column", "static");

                entity.Property(e => e.ColumnId)
                    .ValueGeneratedNever()
                    .HasColumnName("column_id");

                entity.Property(e => e.ColumnDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("column_description");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(128)
                    .HasColumnName("data_type");

                entity.Property(e => e.Datamart).HasColumnName("datamart");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(128)
                    .HasColumnName("default_value");

                entity.Property(e => e.Idw).HasColumnName("idw");

                entity.Property(e => e.IdwHub).HasColumnName("idw_hub");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.OrdinalPosition)
                    .HasColumnName("ordinal_position")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rdw).HasColumnName("rdw");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Staging).HasColumnName("staging");
            });

            modelBuilder.Entity<ColumnEnriched>(entity =>
            {
                entity.HasKey(e => new { e.SchemaName, e.ObjName, e.ObjType, e.ColumnName });

                entity.ToTable("Column_enriched", "static");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(128)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(128)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type")
                    .HasDefaultValueSql("('table')");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId)
                    .HasColumnName("column_type_id")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<ColumnEnrichedExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("column_enriched_ext", "static");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(132)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("schema_name");
            });

            modelBuilder.Entity<ColumnType>(entity =>
            {
                entity.ToTable("Column_type", "static");

                entity.Property(e => e.ColumnTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("column_type_id");

                entity.Property(e => e.ColumnType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("column_type");

                entity.Property(e => e.ColumnTypeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("column_type_description");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user");
            });

            modelBuilder.Entity<DataDic>(entity =>
            {
                entity.HasKey(e => new { e.SchemaName, e.ObjectName, e.ColumnName });

                entity.ToTable("Data_dic", "static");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(128)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(128)
                    .HasColumnName("object_name");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.Definition)
                    .IsUnicode(false)
                    .HasColumnName("definition");

                entity.Property(e => e.Remark)
                    .IsUnicode(false)
                    .HasColumnName("remark");
            });

            modelBuilder.Entity<DepType>(entity =>
            {
                entity.ToTable("Dep_type", "static");

                entity.Property(e => e.DepTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("dep_type_id");

                entity.Property(e => e.DepType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dep_type");

                entity.Property(e => e.DepTypeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dep_type_description");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Error>(entity =>
            {
                entity.ToTable("Error");

                entity.Property(e => e.ErrorId).HasColumnName("error_id");

                entity.Property(e => e.ErrorCode).HasColumnName("error_code");

                entity.Property(e => e.ErrorEventName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_event_name");

                entity.Property(e => e.ErrorExecutionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_execution_id");

                entity.Property(e => e.ErrorInteractiveMode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_interactive_mode");

                entity.Property(e => e.ErrorLine).HasColumnName("error_line");

                entity.Property(e => e.ErrorMachineName)
                    .HasMaxLength(255)
                    .HasColumnName("error_machine_name");

                entity.Property(e => e.ErrorMsg)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("error_msg");

                entity.Property(e => e.ErrorProcedure)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_procedure");

                entity.Property(e => e.ErrorProcedureId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_procedure_id");

                entity.Property(e => e.ErrorSeverity).HasColumnName("error_severity");

                entity.Property(e => e.ErrorSource)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_source");

                entity.Property(e => e.ErrorState).HasColumnName("error_state");

                entity.Property(e => e.ErrorUserName)
                    .HasMaxLength(128)
                    .HasColumnName("error_user_name");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user");

                entity.Property(e => e.TransferId).HasColumnName("transfer_id");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.HasIndex(e => e.Name, "IX_Job")
                    .IsUnique();

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobScheduleId).HasColumnName("job_schedule_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.JobSchedule)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobScheduleId)
                    .HasConstraintName("FK_Job_Job_schedule");
            });

            modelBuilder.Entity<JobExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Job_ext");

                entity.Property(e => e.ActiveEndDate).HasColumnName("active_end_date");

                entity.Property(e => e.ActiveEndTime).HasColumnName("active_end_time");

                entity.Property(e => e.ActiveStartDate).HasColumnName("active_start_date");

                entity.Property(e => e.ActiveStartTime).HasColumnName("active_start_time");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.FreqInterval).HasColumnName("freq_interval");

                entity.Property(e => e.FreqRecurrenceFactor).HasColumnName("freq_recurrence_factor");

                entity.Property(e => e.FreqRelativeInterval).HasColumnName("freq_relative_interval");

                entity.Property(e => e.FreqSubdayInterval).HasColumnName("freq_subday_interval");

                entity.Property(e => e.FreqSubdayType).HasColumnName("freq_subday_type");

                entity.Property(e => e.FreqType).HasColumnName("freq_type");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("job_description");

                entity.Property(e => e.JobEnabled).HasColumnName("job_enabled");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.JobName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("job_name");

                entity.Property(e => e.JobScheduleId).HasColumnName("job_schedule_id");

                entity.Property(e => e.ScheduleEnabled).HasColumnName("schedule_enabled");

                entity.Property(e => e.ScheduleName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("schedule_name");
            });

            modelBuilder.Entity<JobSchedule>(entity =>
            {
                entity.ToTable("Job_schedule");

                entity.HasIndex(e => e.JobScheduleId, "IX_Job_schedule")
                    .IsUnique();

                entity.Property(e => e.JobScheduleId).HasColumnName("job_schedule_id");

                entity.Property(e => e.ActiveEndDate).HasColumnName("active_end_date");

                entity.Property(e => e.ActiveEndTime).HasColumnName("active_end_time");

                entity.Property(e => e.ActiveStartDate).HasColumnName("active_start_date");

                entity.Property(e => e.ActiveStartTime).HasColumnName("active_start_time");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.FreqInterval).HasColumnName("freq_interval");

                entity.Property(e => e.FreqRecurrenceFactor).HasColumnName("freq_recurrence_factor");

                entity.Property(e => e.FreqRelativeInterval).HasColumnName("freq_relative_interval");

                entity.Property(e => e.FreqSubdayInterval).HasColumnName("freq_subday_interval");

                entity.Property(e => e.FreqSubdayType).HasColumnName("freq_subday_type");

                entity.Property(e => e.FreqType).HasColumnName("freq_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<JobStep>(entity =>
            {
                entity.ToTable("Job_step");

                entity.Property(e => e.JobStepId).HasColumnName("job_step_id");

                entity.Property(e => e.Command)
                    .HasMaxLength(4000)
                    .HasColumnName("command");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("database_name")
                    .HasDefaultValueSql("('master')");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.OnFailAction)
                    .HasColumnName("on_fail_action")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.OnFailStepId).HasColumnName("on_fail_step_id");

                entity.Property(e => e.OnSuccessAction)
                    .HasColumnName("on_success_action")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.OnSuccessStepId)
                    .HasColumnName("on_success_step_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StepId)
                    .HasColumnName("step_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StepName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("step_name");

                entity.Property(e => e.Subsystem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subsystem")
                    .HasDefaultValueSql("('SSIS')");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobSteps)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Job_step_Job");
            });

            modelBuilder.Entity<JobStepExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Job_step_ext");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("category_name");

                entity.Property(e => e.Command)
                    .HasMaxLength(4000)
                    .HasColumnName("command");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("database_name");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("job_description");

                entity.Property(e => e.JobEnabled).HasColumnName("job_enabled");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.JobName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("job_name");

                entity.Property(e => e.OnFailAction).HasColumnName("on_fail_action");

                entity.Property(e => e.OnFailStepId).HasColumnName("on_fail_step_id");

                entity.Property(e => e.OnSuccessAction).HasColumnName("on_success_action");

                entity.Property(e => e.OnSuccessStepId).HasColumnName("on_success_step_id");

                entity.Property(e => e.ScheduleEnabled).HasColumnName("schedule_enabled");

                entity.Property(e => e.ScheduleName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("schedule_name");

                entity.Property(e => e.StepId).HasColumnName("step_id");

                entity.Property(e => e.StepName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("step_name");

                entity.Property(e => e.Subsystem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("subsystem");
            });

            modelBuilder.Entity<JoinType>(entity =>
            {
                entity.ToTable("Join_type", "static");

                entity.Property(e => e.JoinTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("join_type_id");

                entity.Property(e => e.JoinType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("join_type");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<KeyDomain>(entity =>
            {
                entity.HasKey(e => e.KeyDomainName);

                entity.ToTable("Key_domain");

                entity.Property(e => e.KeyDomainName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("key_domain_name");

                entity.Property(e => e.KeyDomainId).HasColumnName("key_domain_id");
            });

            modelBuilder.Entity<LogLevel>(entity =>
            {
                entity.ToTable("Log_level", "static");

                entity.Property(e => e.LogLevelId)
                    .ValueGeneratedNever()
                    .HasColumnName("log_level_id");

                entity.Property(e => e.LogLevel1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_level");

                entity.Property(e => e.LogLevelDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("log_level_description");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<LogType>(entity =>
            {
                entity.ToTable("Log_type", "static");

                entity.Property(e => e.LogTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("log_type_id");

                entity.Property(e => e.LogType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("log_type");

                entity.Property(e => e.MinLogLevelId).HasColumnName("min_log_level_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<Logging>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_log_id");

                entity.ToTable("Logging");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.ExecSql).HasColumnName("exec_sql");

                entity.Property(e => e.LogDt)
                    .HasColumnType("datetime")
                    .HasColumnName("log_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogLevelId)
                    .HasColumnName("log_level_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.LogTypeId).HasColumnName("log_type_id");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.TransferId)
                    .HasColumnName("transfer_id")
                    .HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.LogLevel)
                    .WithMany(p => p.Loggings)
                    .HasForeignKey(d => d.LogLevelId)
                    .HasConstraintName("FK_Log_Log_level");

                entity.HasOne(d => d.LogType)
                    .WithMany(p => p.Loggings)
                    .HasForeignKey(d => d.LogTypeId)
                    .HasConstraintName("FK_Log_Log_type");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.Loggings)
                    .HasForeignKey(d => d.TransferId)
                    .HasConstraintName("FK_Log_Transfer");
            });

            modelBuilder.Entity<LoggingExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Logging_ext");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.ExecSql).HasColumnName("exec_sql");

                entity.Property(e => e.LogDt)
                    .HasPrecision(3)
                    .HasColumnName("log_dt");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("log_id");

                entity.Property(e => e.LogLevelId).HasColumnName("log_level_id");

                entity.Property(e => e.LogTypeId).HasColumnName("log_type_id");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.TransferId).HasColumnName("transfer_id");
            });

            modelBuilder.Entity<Monitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Monitor");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(128)
                    .HasColumnName("batch_name");

                entity.Property(e => e.DurationSec).HasColumnName("duration_sec");

                entity.Property(e => e.EndDt)
                    .HasPrecision(3)
                    .HasColumnName("end_dt");

                entity.Property(e => e.Id)
                    .HasMaxLength(4000)
                    .HasColumnName("id");

                entity.Property(e => e.Msg)
                    .IsUnicode(false)
                    .HasColumnName("msg");

                entity.Property(e => e.RecCntChanged).HasColumnName("rec_cnt_changed");

                entity.Property(e => e.RecCntDeleted).HasColumnName("rec_cnt_deleted");

                entity.Property(e => e.RecCntNew).HasColumnName("rec_cnt_new");

                entity.Property(e => e.RecCntSrc).HasColumnName("rec_cnt_src");

                entity.Property(e => e.RecCntUndeleted).HasColumnName("rec_cnt_undeleted");

                entity.Property(e => e.StartDt)
                    .HasPrecision(3)
                    .HasColumnName("start_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TransferName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("transfer_name");
            });

            modelBuilder.Entity<Obj>(entity =>
            {
                entity.ToTable("Obj");

                entity.HasIndex(e => new { e.ObjName, e.ObjTypeId, e.ParentId }, "UI_Obj_h_obj_name_obj_type_parent_id")
                    .IsUnique();

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasDefaultValueSql("(NEXT VALUE FOR [seq_Obj])");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.ExternalObjId)
                    .HasColumnName("external_obj_id")
                    .HasComment("this is the id in the database. e.g. in object_id sys.objects.");

                entity.Property(e => e.Identifier).HasColumnName("identifier");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjNameNoPrefix)
                    .HasMaxLength(255)
                    .HasColumnName("obj_name_no_prefix");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .HasColumnName("prefix");

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

                entity.Property(e => e.SrcObjId)
                    .HasColumnName("src_obj_id")
                    .HasComment("this is the id of the originating object ( lineage)");

                entity.Property(e => e.TransferId).HasColumnName("_transfer_id");

                entity.HasOne(d => d.ObjType)
                    .WithMany(p => p.Objs)
                    .HasForeignKey(d => d.ObjTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_h_Obj_type");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Obj_Obj");

                entity.HasOne(d => d.ServerType)
                    .WithMany(p => p.Objs)
                    .HasForeignKey(d => d.ServerTypeId)
                    .HasConstraintName("FK_Obj_h_Server_type");

                entity.HasOne(d => d.SrcObj)
                    .WithMany(p => p.InverseSrcObj)
                    .HasForeignKey(d => d.SrcObjId)
                    .HasConstraintName("FK_Obj_src_Obj");
            });

            modelBuilder.Entity<ObjDef>(entity =>
            {
                entity.ToTable("Obj_def");

                entity.Property(e => e.ObjDefId).HasColumnName("obj_def_id");

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
//                              .HasDefaultValue(10);
//                .HasDefaultValueSql("10"); // table

                entity.Property(e => e.ParentObjId).HasColumnName("parent_obj_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.ObjType)
                    .WithMany(p => p.ObjDefs)
                    .HasForeignKey(d => d.ObjTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_def_h_Obj_type");

                entity.HasOne(d => d.ParentObj)
                    .WithMany(p => p.ObjDefs)
                    .HasForeignKey(d => d.ParentObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_def_parent_Obj");
            });

            modelBuilder.Entity<ObjDep>(entity =>
            {
                entity.HasKey(e => new { e.ObjId, e.DepObjId, e.DepTypeId })
                    .HasName("PK__Obj_dep__7C69C680D927C550");

                entity.ToTable("Obj_dep");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.DepObjId).HasColumnName("dep_obj_id");

                entity.Property(e => e.DepTypeId).HasColumnName("dep_type_id");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("delete_dt");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.TopSortRank).HasColumnName("top_sort_rank");

                entity.HasOne(d => d.DepObj)
                    .WithMany(p => p.ObjDepDepObjs)
                    .HasForeignKey(d => d.DepObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_dep_Obj3");

                entity.HasOne(d => d.DepType)
                    .WithMany(p => p.ObjDeps)
                    .HasForeignKey(d => d.DepTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_dep_Dep_type");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.ObjDepObjs)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_dep_Obj2");
            });

            modelBuilder.Entity<ObjDepExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_dep_ext");

                entity.Property(e => e.DepDbName)
                    .HasMaxLength(255)
                    .HasColumnName("dep_db_name");

                entity.Property(e => e.DepFullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("dep_full_obj_name");

                entity.Property(e => e.DepObjId).HasColumnName("dep_obj_id");

                entity.Property(e => e.DepObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("dep_obj_name");

                entity.Property(e => e.DepObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dep_obj_type");

                entity.Property(e => e.DepSchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("dep_schema_name");

                entity.Property(e => e.DepType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dep_type");

                entity.Property(e => e.DepTypeId).HasColumnName("dep_type_id");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.ObjDbName)
                    .HasMaxLength(255)
                    .HasColumnName("obj_db_name");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjSchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("obj_schema_name");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.TopSortRank).HasColumnName("top_sort_rank");
            });

            modelBuilder.Entity<ObjExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_ext");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultTemplateId).HasColumnName("default_template_id");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.GrandParentId).HasColumnName("grand_parent_id");

                entity.Property(e => e.GreatGrandParentId).HasColumnName("great_grand_parent_id");

                entity.Property(e => e.Identifier).HasColumnName("identifier");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjNameNoPrefix)
                    .HasMaxLength(255)
                    .HasColumnName("obj_name_no_prefix");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .HasColumnName("prefix");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user");

                entity.Property(e => e.RequestCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_create_dt");

                entity.Property(e => e.RequestDeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_delete_dt");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.SchemaObjName)
                    .HasMaxLength(517)
                    .HasColumnName("schema_obj_name");

                entity.Property(e => e.SchemaObject)
                    .HasMaxLength(255)
                    .HasColumnName("schema_object");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("server_type");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjExtAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_ext_all");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultTemplateId).HasColumnName("default_template_id");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.GrandParentId).HasColumnName("grand_parent_id");

                entity.Property(e => e.GreatGrandParentId).HasColumnName("great_grand_parent_id");

                entity.Property(e => e.Identifier).HasColumnName("identifier");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjNameNoPrefix)
                    .HasMaxLength(255)
                    .HasColumnName("obj_name_no_prefix");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .HasColumnName("prefix");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user");

                entity.Property(e => e.RequestCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_create_dt");

                entity.Property(e => e.RequestDeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_request_delete_dt");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.SchemaObjName)
                    .HasMaxLength(517)
                    .HasColumnName("schema_obj_name");

                entity.Property(e => e.SchemaObject)
                    .HasMaxLength(255)
                    .HasColumnName("schema_object");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("server_type");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjExtAllUnpivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_ext_all_unpivot");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("_name");

                entity.Property(e => e.ObjId).HasColumnName("_obj_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .HasColumnName("_value");
            });

            modelBuilder.Entity<ObjExtUnpivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_ext_unpivot");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("_name");

                entity.Property(e => e.ObjId).HasColumnName("_obj_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(128)
                    .HasColumnName("_value");
            });

            modelBuilder.Entity<ObjMap>(entity =>
            {
                entity.ToTable("Obj_map");

                entity.Property(e => e.ObjMapId).HasColumnName("obj_map_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.JoinTypeId).HasColumnName("join_type_id");

                entity.Property(e => e.ObjDefId).HasColumnName("obj_def_id");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.ObjMaps)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_def_mapping_Obj");
            });

            modelBuilder.Entity<ObjMapTransform>(entity =>
            {
                entity.HasKey(e => new { e.ObjMapId, e.TransformId });

                entity.ToTable("Obj_map_transform");

                entity.Property(e => e.ObjMapId).HasColumnName("obj_map_id");

                entity.Property(e => e.TransformId).HasColumnName("transform_id");

                entity.Property(e => e.BatchId).HasColumnName("_batch_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(255)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.Transform)
                    .WithMany(p => p.ObjMapTransforms)
                    .HasForeignKey(d => d.TransformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obj_map_transform_id");
            });

            modelBuilder.Entity<ObjTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_transfer");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.MaxTransferDt)
                    .HasColumnType("datetime")
                    .HasColumnName("max_transfer_dt");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");
            });

            modelBuilder.Entity<ObjTreeIdwHubCol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_idw_hub_cols");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(4000)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(128)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeIdwHubsNatPkeySize>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_idw_hubs_nat_pkey_size");

                entity.Property(e => e.NatPkeySize).HasColumnName("nat_pkey_size");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");
            });

            modelBuilder.Entity<ObjTreeIdwTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_idw_tables");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeIdwTableColsBasic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_idw_table_cols_basic");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeIdwView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_idw_views");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(4000)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeRdwTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_rdw_tables");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(128)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(257)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeRdwView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_rdw_views");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(4000)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeStagingTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_staging_tables");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(128)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .HasMaxLength(767)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting).HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(128)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjTreeStagingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Obj_tree_staging_views");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(128)
                    .HasColumnName("column_name");

                entity.Property(e => e.ColumnTypeId).HasColumnName("column_type_id");

                entity.Property(e => e.DataType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data_type");

                entity.Property(e => e.DbName)
                    .HasMaxLength(255)
                    .HasColumnName("db_name");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .HasColumnName("default_value");

                entity.Property(e => e.ExternalObjId).HasColumnName("external_obj_id");

                entity.Property(e => e.IsNullable).HasColumnName("is_nullable");

                entity.Property(e => e.MaxLen).HasColumnName("max_len");

                entity.Property(e => e.NumericPrecision).HasColumnName("numeric_precision");

                entity.Property(e => e.NumericScale).HasColumnName("numeric_scale");

                entity.Property(e => e.ObjName)
                    .IsRequired()
                    .HasMaxLength(259)
                    .HasColumnName("obj_name");

                entity.Property(e => e.ObjTypeId).HasColumnName("obj_type_id");

                entity.Property(e => e.OrdinalPosition).HasColumnName("ordinal_position");

                entity.Property(e => e.PrimaryKeySorting)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("primary_key_sorting");

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(255)
                    .HasColumnName("schema_name");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(255)
                    .HasColumnName("server_name");

                entity.Property(e => e.ServerTypeId).HasColumnName("server_type_id");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_source");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");
            });

            modelBuilder.Entity<ObjType>(entity =>
            {
                entity.ToTable("Obj_type", "static");

                entity.Property(e => e.ObjTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("obj_type_id")
                    .HasDefaultValue(10);

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

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.HasKey(e => e.PrefixName)
                    .HasName("PK_Prefix_1");

                entity.ToTable("Prefix");

                entity.Property(e => e.PrefixName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prefix_name");

                entity.Property(e => e.DefaultTemplateId).HasColumnName("default_template_id");
            });

            modelBuilder.Entity<PropExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Prop_ext");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("default_value");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.FullObjName)
                    .IsRequired()
                    .HasMaxLength(1033)
                    .HasColumnName("full_obj_name");

                entity.Property(e => e.GrandParentValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("grand_parent_value");

                entity.Property(e => e.GreatGrandParentValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("great_grand_parent_value");

                entity.Property(e => e.InheritedValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("inherited_value");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ObjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obj_type");

                entity.Property(e => e.ParentValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("parent_value");

                entity.Property(e => e.Property)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("property");

                entity.Property(e => e.PropertyId).HasColumnName("property_id");

                entity.Property(e => e.PropertyScope)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("property_scope");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property", "static");

                entity.Property(e => e.PropertyId)
                    .ValueGeneratedNever()
                    .HasColumnName("property_id");

                entity.Property(e => e.ApplyDb).HasColumnName("apply_db");

                entity.Property(e => e.ApplySchema).HasColumnName("apply_schema");

                entity.Property(e => e.ApplySrv).HasColumnName("apply_srv");

                entity.Property(e => e.ApplyTable).HasColumnName("apply_table");

                entity.Property(e => e.ApplyView).HasColumnName("apply_view");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("default_value");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("property_name");

                entity.Property(e => e.PropertyScope)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("property_scope");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<PropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.ObjId })
                    .HasName("PK_Property_Value");

                entity.ToTable("Property_value");

                entity.Property(e => e.PropertyId).HasColumnName("property_id");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.PropertyValues)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Property_value_Obj1");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValues)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Property_value_Property");
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.ToTable("Rule", "static");

                entity.Property(e => e.RuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("rule_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user");

                entity.Property(e => e.RuleDescription)
                    .IsUnicode(false)
                    .HasColumnName("rule_description");

                entity.Property(e => e.RuleRationale)
                    .IsUnicode(false)
                    .HasColumnName("rule_rationale");

                entity.Property(e => e.RuleSqlExample)
                    .IsUnicode(false)
                    .HasColumnName("rule_sql_example");
            });

            modelBuilder.Entity<RuleMapping>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.ObjId, e.ColumnId });

                entity.ToTable("Rule_mapping");

                entity.Property(e => e.RuleId).HasColumnName("rule_id");

                entity.Property(e => e.ObjId).HasColumnName("obj_id");

                entity.Property(e => e.ColumnId).HasColumnName("column_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.RuleMappings)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rule_mapping_Obj");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleMappings)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rule_mapping_Rule");
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

            modelBuilder.Entity<Stack>(entity =>
            {
                entity.ToTable("Stack");

                entity.Property(e => e.StackId).HasColumnName("stack_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.Value)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "static");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("status_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IsRunning).HasColumnName("is_running");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status_name");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template", "static");

                entity.HasIndex(e => e.TemplateName, "IX_Template_name")
                    .IsUnique();

                entity.Property(e => e.TemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("template_id");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordName)
                    .HasMaxLength(128)
                    .HasColumnName("_record_name")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.TemplateCode).HasColumnName("template_code");

                entity.Property(e => e.TemplateDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("template_description");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("template_name");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.Property(e => e.TransferId).HasColumnName("transfer_id");

                entity.Property(e => e.BatchId)
                    .HasColumnName("batch_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Guid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("guid");

                entity.Property(e => e.LastErrorId)
                    .HasColumnName("last_error_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PrevTransferId)
                    .HasColumnName("prev_transfer_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.RecCntChanged).HasColumnName("rec_cnt_changed");

                entity.Property(e => e.RecCntDeleted).HasColumnName("rec_cnt_deleted");

                entity.Property(e => e.RecCntNew).HasColumnName("rec_cnt_new");

                entity.Property(e => e.RecCntSrc).HasColumnName("rec_cnt_src");

                entity.Property(e => e.RecCntUndeleted).HasColumnName("rec_cnt_undeleted");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user")
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.SrcObjId)
                    .HasColumnName("src_obj_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TransferEndDt)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_end_dt");

                entity.Property(e => e.TransferName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("transfer_name");

                entity.Property(e => e.TransferSeq)
                    .HasColumnName("transfer_seq")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.TransferStartDt)
                    .HasColumnType("datetime")
                    .HasColumnName("transfer_start_dt");

                entity.Property(e => e.TrgObjId).HasColumnName("trg_obj_id");

                entity.Property(e => e.TrgObjName)
                    .HasMaxLength(255)
                    .HasColumnName("trg_obj_name");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.BatchId)
                    .HasConstraintName("FK_Transfer_Batch");

                entity.HasOne(d => d.LastError)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.LastErrorId)
                    .HasConstraintName("FK_Transfer_Error");

                entity.HasOne(d => d.PrevTransfer)
                    .WithMany(p => p.InversePrevTransfer)
                    .HasForeignKey(d => d.PrevTransferId)
                    .HasConstraintName("FK_Transfer_Transfer");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Transfer_Status");
            });

            modelBuilder.Entity<TransferExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Transfer_ext");

                entity.Property(e => e.BatchEndDt)
                    .HasPrecision(3)
                    .HasColumnName("batch_end_dt");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(128)
                    .HasColumnName("batch_name");

                entity.Property(e => e.BatchStartDt)
                    .HasPrecision(3)
                    .HasColumnName("batch_start_dt");

                entity.Property(e => e.BatchStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_status");

                entity.Property(e => e.LastErrorId).HasColumnName("last_error_id");

                entity.Property(e => e.RecCntChanged).HasColumnName("rec_cnt_changed");

                entity.Property(e => e.RecCntDeleted).HasColumnName("rec_cnt_deleted");

                entity.Property(e => e.RecCntNew).HasColumnName("rec_cnt_new");

                entity.Property(e => e.RecCntSrc).HasColumnName("rec_cnt_src");

                entity.Property(e => e.SrcObjId).HasColumnName("src_obj_id");

                entity.Property(e => e.TransferEndDt)
                    .HasPrecision(3)
                    .HasColumnName("transfer_end_dt");

                entity.Property(e => e.TransferId).HasColumnName("transfer_id");

                entity.Property(e => e.TransferName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("transfer_name");

                entity.Property(e => e.TransferStartDt)
                    .HasPrecision(3)
                    .HasColumnName("transfer_start_dt");

                entity.Property(e => e.TransferStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transfer_status");

                entity.Property(e => e.TrgObjId).HasColumnName("trg_obj_id");

                entity.Property(e => e.TrgObjName)
                    .HasMaxLength(255)
                    .HasColumnName("trg_obj_name");
            });

            modelBuilder.Entity<Transform>(entity =>
            {
                entity.ToTable("Transform");

                entity.Property(e => e.TransformId)
                    .ValueGeneratedNever()
                    .HasColumnName("transform_id");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_delete_dt");

                entity.Property(e => e.Rationale)
                    .IsUnicode(false)
                    .HasColumnName("rationale");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("_record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("_record_user");

                entity.Property(e => e.TransformCode)
                    .IsUnicode(false)
                    .HasColumnName("transform_code");

                entity.Property(e => e.TransformDescription)
                    .IsUnicode(false)
                    .HasColumnName("transform_description");
            });

            modelBuilder.Entity<BetlApp.Data.Version>(entity =>
            {
                entity.HasKey(e => new { e.MajorVersion, e.MinorVersion, e.Build });

                entity.ToTable("Version", "static");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.Build).HasColumnName("build");

                entity.Property(e => e.BuildDt)
                    .HasColumnType("datetime")
                    .HasColumnName("build_dt");

                entity.Property(e => e.RecordDt)
                    .HasColumnType("datetime")
                    .HasColumnName("record_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecordUser)
                    .HasMaxLength(128)
                    .HasColumnName("record_user")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.HasSequence<int>("seq_col_hist");

            modelBuilder.HasSequence("seq_Obj").StartsAt(0);

            modelBuilder.HasSequence("seq_Obj_def").StartsAt(0);

            modelBuilder.HasSequence("seq_Obj_mapping").StartsAt(0);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
