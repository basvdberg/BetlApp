using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Transfer
    {
        public Transfer()
        {
            InversePrevTransfer = new HashSet<Transfer>();
            Loggings = new HashSet<Logging>();
        }

        public int TransferId { get; set; }
        public int? BatchId { get; set; }
        public string TransferName { get; set; }
        public int? SrcObjId { get; set; }
        public int? TrgObjId { get; set; }
        public string TrgObjName { get; set; }
        public DateTime? TransferStartDt { get; set; }
        public DateTime? TransferEndDt { get; set; }
        public int? StatusId { get; set; }
        public int? RecCntSrc { get; set; }
        public int? RecCntNew { get; set; }
        public int? RecCntChanged { get; set; }
        public int? RecCntDeleted { get; set; }
        public int? RecCntUndeleted { get; set; }
        public int? LastErrorId { get; set; }
        public int? PrevTransferId { get; set; }
        public int? TransferSeq { get; set; }
        public string Guid { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Error LastError { get; set; }
        public virtual Transfer PrevTransfer { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Transfer> InversePrevTransfer { get; set; }
        public virtual ICollection<Logging> Loggings { get; set; }
    }
}
