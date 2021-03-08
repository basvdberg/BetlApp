using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class LoggingExt
    {
        public int LogId { get; set; }
        public DateTimeOffset? LogDt { get; set; }
        public string Msg { get; set; }
        public int? TransferId { get; set; }
        public int? BatchId { get; set; }
        public short? LogLevelId { get; set; }
        public short? LogTypeId { get; set; }
        public bool? ExecSql { get; set; }
    }
}
