using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class BatchExt
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public DateTimeOffset? BatchStartDt { get; set; }
        public DateTimeOffset? BatchEndDt { get; set; }
        public string BatchStatus { get; set; }
        public int? PrevBatchId { get; set; }
        public DateTimeOffset? PrevBatchStartDt { get; set; }
        public DateTimeOffset? PrevBatchEndDt { get; set; }
        public string PrevBatchStatus { get; set; }
    }
}
