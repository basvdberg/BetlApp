using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class LogLevel
    {
        public LogLevel()
        {
            Loggings = new HashSet<Logging>();
        }

        public short LogLevelId { get; set; }
        public string LogLevel1 { get; set; }
        public string LogLevelDescription { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<Logging> Loggings { get; set; }
    }
}
