using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColumnEnrichedExt
    {
        public string SchemaName { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnTypeId { get; set; }
    }
}
