using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjMapTransform
    {
        public int ObjMapId { get; set; }
        public int TransformId { get; set; }
        public int OrdinalPosition { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int? BatchId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual Transform Transform { get; set; }
    }
}
