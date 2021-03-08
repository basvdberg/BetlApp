using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Logging
    {
        public int LogId { get; set; }
        public DateTime? LogDt { get; set; }
        public string Msg { get; set; }
        public int? TransferId { get; set; }
        public int? BatchId { get; set; }
        public short? LogLevelId { get; set; }
        public short? LogTypeId { get; set; }
        public bool? ExecSql { get; set; }

        public virtual LogLevel LogLevel { get; set; }
        public virtual LogType LogType { get; set; }
        public virtual Transfer Transfer { get; set; }
    }
}
