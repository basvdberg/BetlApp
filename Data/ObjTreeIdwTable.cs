using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjTreeIdwTable
    {
        public int SrcObjId { get; set; }
        public int? ExternalObjId { get; set; }
        public string DbName { get; set; }
        public string SchemaName { get; set; }
        public string ObjName { get; set; }
        public string ServerName { get; set; }
        public int? ServerTypeId { get; set; }
        public string Source { get; set; }
    }
}
