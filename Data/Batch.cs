using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Batch
    {
        public Batch()
        {
            InversePrevBatch = new HashSet<Batch>();
            Transfers = new HashSet<Transfer>();
        }

        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int? ParentBatchId { get; set; }
        public DateTime? BatchStartDt { get; set; }
        public DateTime? BatchEndDt { get; set; }
        public int? StatusId { get; set; }
        public int? LastErrorId { get; set; }
        public int? PrevBatchId { get; set; }
        public string ExecServer { get; set; }
        public string ExecHost { get; set; }
        public string ExecUser { get; set; }
        public string Guid { get; set; }
        public bool? ContinueBatch { get; set; }
        public int? BatchSeq { get; set; }

        public virtual Error LastError { get; set; }
        public virtual Batch PrevBatch { get; set; }
        public virtual ICollection<Batch> InversePrevBatch { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
