using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Monitor
    {
        public string Id { get; set; }
        public string BatchName { get; set; }
        public string TransferName { get; set; }
        public string Msg { get; set; }
        public DateTimeOffset? StartDt { get; set; }
        public DateTimeOffset? EndDt { get; set; }
        public int? DurationSec { get; set; }
        public string Status { get; set; }
        public int? RecCntSrc { get; set; }
        public int? RecCntNew { get; set; }
        public int? RecCntChanged { get; set; }
        public int? RecCntDeleted { get; set; }
        public int? RecCntUndeleted { get; set; }
    }
}
