using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Transform
    {
        public Transform()
        {
            ColMapTransforms = new HashSet<ColMapTransform>();
            ObjMapTransforms = new HashSet<ObjMapTransform>();
        }

        public int TransformId { get; set; }
        public string TransformCode { get; set; }
        public string TransformDescription { get; set; }
        public string Rationale { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ColMapTransform> ColMapTransforms { get; set; }
        public virtual ICollection<ObjMapTransform> ObjMapTransforms { get; set; }
    }
}
