using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Stack
    {
        public int StackId { get; set; }
        public string Value { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
    }
}
