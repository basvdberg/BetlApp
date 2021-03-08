using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColumnType
    {
        public ColumnType()
        {
            ColHs = new HashSet<ColH>();
        }

        public int ColumnTypeId { get; set; }
        public string ColumnType1 { get; set; }
        public string ColumnTypeDescription { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ColH> ColHs { get; set; }
    }
}
