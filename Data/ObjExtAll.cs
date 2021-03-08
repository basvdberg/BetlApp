using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjExtAll
    {
        public int ObjId { get; set; }
        public string FullObjName { get; set; }
        public string SchemaObjName { get; set; }
        public string ObjType { get; set; }
        public string ServerType { get; set; }
        public string ObjName { get; set; }
        public string ServerName { get; set; }
        public string DbName { get; set; }
        public string SchemaName { get; set; }
        public string SchemaObject { get; set; }
        public int? ParentId { get; set; }
        public int? GrandParentId { get; set; }
        public int? GreatGrandParentId { get; set; }
        public int? ServerTypeId { get; set; }
        public DateTime? CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public DateTime? RequestCreateDt { get; set; }
        public DateTime? RequestDeleteDt { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }
        public string Prefix { get; set; }
        public string ObjNameNoPrefix { get; set; }
        public short? DefaultTemplateId { get; set; }
        public int? Identifier { get; set; }
        public int? SrcObjId { get; set; }
        public int? ExternalObjId { get; set; }
        public string Source { get; set; }
    }
}
