using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjDep
    {
        public int ObjId { get; set; }
        public int DepObjId { get; set; }
        public short DepTypeId { get; set; }
        public short? TopSortRank { get; set; }
        public DateTime? DeleteDt { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual Obj DepObj { get; set; }
        public virtual DepType DepType { get; set; }
        public virtual Obj Obj { get; set; }
    }
}
