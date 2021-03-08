using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjTreeStagingTable
    {
        public int SrcObjId { get; set; }
        public int? ExternalObjId { get; set; }
        public int ServerTypeId { get; set; }
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string SchemaName { get; set; }
        public string ObjName { get; set; }
        public int ObjTypeId { get; set; }
        public long? OrdinalPosition { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnTypeId { get; set; }
        public bool? IsNullable { get; set; }
        public string DataType { get; set; }
        public int? MaxLen { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public int? PrimaryKeySorting { get; set; }
        public string DefaultValue { get; set; }
        public string Source { get; set; }
    }
}
