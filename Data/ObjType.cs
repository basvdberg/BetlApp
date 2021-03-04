using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjType
    {
        public ObjType()
        {
            ObjDefs = new HashSet<ObjDef>();
        }

        public int ObjTypeId { get; set; }
        public string ObjType1 { get; set; }
        public int? ObjTypeLevel { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ObjDef> ObjDefs { get; set; }
    }
}
