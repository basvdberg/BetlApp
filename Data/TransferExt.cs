using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class TransferExt
    {
        public int TransferId { get; set; }
        public string TransferName { get; set; }
        public int? SrcObjId { get; set; }
        public int? TrgObjId { get; set; }
        public string TrgObjName { get; set; }
        public DateTimeOffset? TransferStartDt { get; set; }
        public DateTimeOffset? TransferEndDt { get; set; }
        public string TransferStatus { get; set; }
        public int? RecCntSrc { get; set; }
        public int? RecCntNew { get; set; }
        public int? RecCntChanged { get; set; }
        public int? RecCntDeleted { get; set; }
        public int? LastErrorId { get; set; }
        public int? BatchId { get; set; }
        public DateTimeOffset? BatchStartDt { get; set; }
        public DateTimeOffset? BatchEndDt { get; set; }
        public string BatchName { get; set; }
        public string BatchStatus { get; set; }
    }
}
