using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class LogType
    {
        public LogType()
        {
            Loggings = new HashSet<Logging>();
        }

        public short LogTypeId { get; set; }
        public string LogType1 { get; set; }
        public int? MinLogLevelId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<Logging> Loggings { get; set; }
    }
}
