using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Property
    {
        public Property()
        {
            PropertyValues = new HashSet<PropertyValue>();
        }

        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public bool? Enabled { get; set; }
        public string Description { get; set; }
        public string PropertyScope { get; set; }
        public string DefaultValue { get; set; }
        public bool? ApplyTable { get; set; }
        public bool? ApplyView { get; set; }
        public bool? ApplySchema { get; set; }
        public bool? ApplyDb { get; set; }
        public bool? ApplySrv { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<PropertyValue> PropertyValues { get; set; }
    }
}
