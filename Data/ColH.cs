using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColH
    {
        public int ColumnId { get; set; }
        public DateTime EffDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int ObjId { get; set; }
        public short? OrdinalPosition { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnTypeId { get; set; }
        public bool? IsNullable { get; set; }
        public string DataType { get; set; }
        public int? MaxLen { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public bool? PartOfUniqueIndex { get; set; }
        public string PrimaryKeySorting { get; set; }
        public string DefaultValue { get; set; }
        public byte[] Chksum { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
        public int? TransferId { get; set; }

        public virtual ColumnType ColumnType { get; set; }
        public virtual Obj Obj { get; set; }
    }
}
