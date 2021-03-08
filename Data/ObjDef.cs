using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjDef
    {
        public ObjDef()
        {
            ColDefs = new HashSet<ColDef>();
            ObjTypeId = 10;
            ParentObjId = -1;

        }

        public int ObjDefId { get; set; }
        public int ParentObjId { get; set; }
        public string ObjName { get; set; }
        public int ObjTypeId { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int? BatchId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ObjType ObjType { get; set; }
        public virtual Obj ParentObj { get; set; }
        public virtual ICollection<ColDef> ColDefs { get; set; }
    }
}
