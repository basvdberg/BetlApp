using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class JoinType
    {
        public int JoinTypeId { get; set; }
        public string JoinType1 { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
    }
}
