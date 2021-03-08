using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColExt
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnTypeId { get; set; }
        public string ColumnType { get; set; }
        public string SchemaName { get; set; }
        public string DbName { get; set; }
        public string FullObjName { get; set; }
        public bool? IsNullable { get; set; }
        public short? OrdinalPosition { get; set; }
        public string DataType { get; set; }
        public int? MaxLen { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public int ObjId { get; set; }
        public int? SrcObjId { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public byte[] Chksum { get; set; }
        public bool? PartOfUniqueIndex { get; set; }
        public int? ServerTypeId { get; set; }
        public string DefaultValue { get; set; }
        public string ServerName { get; set; }
        public string PrimaryKeySorting { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public DateTime? RequestCreateDt { get; set; }
        public DateTime? RequestDeleteDt { get; set; }
    }
}
