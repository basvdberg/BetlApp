using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class CacheUserDatum
    {
        public string UserName { get; set; }
        public string LogLevel { get; set; }
        public bool? ExecSql { get; set; }
        public DateTime? RecordDt { get; set; }
        public DateTime? ExpirationDt { get; set; }
    }
}
