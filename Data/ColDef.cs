using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColDef
    {
        public int ColDefId { get; set; }
        public int ObjDefId { get; set; }
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
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
        public int? BatchId { get; set; }

        public virtual ObjDef ObjDef { get; set; }
    }
}
