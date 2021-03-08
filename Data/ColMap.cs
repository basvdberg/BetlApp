using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ColMap
    {
        public ColMap()
        {
            ColMapTransforms = new HashSet<ColMapTransform>();
        }

        public int ColMapId { get; set; }
        public int ColDefId { get; set; }
        public int ColumnId { get; set; }
        public int? JoinTypeId { get; set; }
        public int OrdinalPosition { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int? BatchId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<ColMapTransform> ColMapTransforms { get; set; }
    }
}
