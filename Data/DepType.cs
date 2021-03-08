using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class DepType
    {
        public DepType()
        {
            ObjDeps = new HashSet<ObjDep>();
        }

        public short DepTypeId { get; set; }
        public string DepType1 { get; set; }
        public string DepTypeDescription { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ObjDep> ObjDeps { get; set; }
    }
}
