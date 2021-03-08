using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Obj
    {
        public Obj()
        {
            ColHs = new HashSet<ColH>();
            InverseParent = new HashSet<Obj>();
            InverseSrcObj = new HashSet<Obj>();
            ObjDefs = new HashSet<ObjDef>();
            ObjDepDepObjs = new HashSet<ObjDep>();
            ObjDepObjs = new HashSet<ObjDep>();
            ObjMaps = new HashSet<ObjMap>();
            PropertyValues = new HashSet<PropertyValue>();
            RuleMappings = new HashSet<RuleMapping>();
        }

        public int ObjId { get; set; }
        public string ObjName { get; set; }
        public int ObjTypeId { get; set; }
        public int? ParentId { get; set; }
        public string Prefix { get; set; }
        public string ObjNameNoPrefix { get; set; }
        public int? ServerTypeId { get; set; }
        public int? Identifier { get; set; }
        public int? SrcObjId { get; set; }
        public int? ExternalObjId { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public int? TransferId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ObjType ObjType { get; set; }
        public virtual Obj Parent { get; set; }
        public virtual ServerType ServerType { get; set; }
        public virtual Obj SrcObj { get; set; }
        public virtual ICollection<ColH> ColHs { get; set; }
        public virtual ICollection<Obj> InverseParent { get; set; }
        public virtual ICollection<Obj> InverseSrcObj { get; set; }
        public virtual ICollection<ObjDef> ObjDefs { get; set; }
        public virtual ICollection<ObjDep> ObjDepDepObjs { get; set; }
        public virtual ICollection<ObjDep> ObjDepObjs { get; set; }
        public virtual ICollection<ObjMap> ObjMaps { get; set; }
        public virtual ICollection<PropertyValue> PropertyValues { get; set; }
        public virtual ICollection<RuleMapping> RuleMappings { get; set; }
    }
}
