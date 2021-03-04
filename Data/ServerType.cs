using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ServerType
    {
        public ServerType()
        {
            ObjDefs = new HashSet<ObjDef>();
        }

        public int ServerTypeId { get; set; }
        public string ServerType1 { get; set; }
        public string Compatibility { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ObjDef> ObjDefs { get; set; }
    }
}
