using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class PropExt
    {
        public int ObjId { get; set; }
        public string ObjType { get; set; }
        public string FullObjName { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int PropertyId { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public string InheritedValue { get; set; }
        public string DefaultValue { get; set; }
        public string PropertyScope { get; set; }
        public DateTime? RecordDt { get; set; }
        public string ParentValue { get; set; }
        public string GrandParentValue { get; set; }
        public string GreatGrandParentValue { get; set; }
    }
}
