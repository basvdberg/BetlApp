using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class RuleMapping
    {
        public int RuleId { get; set; }
        public int ObjId { get; set; }
        public int ColumnId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual Obj Obj { get; set; }
        public virtual Rule Rule { get; set; }
    }
}
