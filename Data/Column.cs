using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Column
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public int? ColumnTypeId { get; set; }
        public int? OrdinalPosition { get; set; }
        public string DataType { get; set; }
        public int? MaxLen { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsNullable { get; set; }
        public string PrimaryKeySorting { get; set; }
        public bool? Staging { get; set; }
        public bool? Rdw { get; set; }
        public bool? Idw { get; set; }
        public bool? IdwHub { get; set; }
        public bool? Datamart { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
    }
}
