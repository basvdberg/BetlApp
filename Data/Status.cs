using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Status
    {
        public Status()
        {
            Transfers = new HashSet<Transfer>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsRunning { get; set; }
        public string Description { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
