using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Version
    {
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int Build { get; set; }
        public DateTime? BuildDt { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
    }
}
