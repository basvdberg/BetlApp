using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class DataDic
    {
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string ColumnName { get; set; }
        public string Definition { get; set; }
        public string Remark { get; set; }
    }
}
