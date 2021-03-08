using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Error
    {
        public Error()
        {
            Batches = new HashSet<Batch>();
            Transfers = new HashSet<Transfer>();
        }

        public int ErrorId { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorProcedure { get; set; }
        public string ErrorProcedureId { get; set; }
        public string ErrorExecutionId { get; set; }
        public string ErrorEventName { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public string ErrorSource { get; set; }
        public string ErrorInteractiveMode { get; set; }
        public string ErrorMachineName { get; set; }
        public string ErrorUserName { get; set; }
        public int? TransferId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<Batch> Batches { get; set; }
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
