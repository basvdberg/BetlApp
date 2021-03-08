using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class PropertyValue
    {
        public int PropertyId { get; set; }
        public int ObjId { get; set; }
        public string Value { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual Obj Obj { get; set; }
        public virtual Property Property { get; set; }
    }
}
