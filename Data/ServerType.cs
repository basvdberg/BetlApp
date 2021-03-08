using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ServerType
    {
        public ServerType()
        {
            Objs = new HashSet<Obj>();
        }

        public int ServerTypeId { get; set; }
        public string ServerType1 { get; set; }
        public string Compatibility { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<Obj> Objs { get; set; }
    }
}
