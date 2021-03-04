using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjDef
    {
        public int Id { get; set; }
        public string ObjName { get; set; }
        public int ObjTypeId { get; set; }
        public int? ServerTypeId { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int? BatchId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ObjType ObjType { get; set; }
        public virtual ServerType ServerType { get; set; }
    }
}
