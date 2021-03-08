using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjDepExt
    {
        public int ObjId { get; set; }
        public short? TopSortRank { get; set; }
        public string FullObjName { get; set; }
        public int DepObjId { get; set; }
        public string DepFullObjName { get; set; }
        public short DepTypeId { get; set; }
        public string DepType { get; set; }
        public string ObjDbName { get; set; }
        public string ObjSchemaName { get; set; }
        public string ObjName { get; set; }
        public string ObjType { get; set; }
        public string DepDbName { get; set; }
        public string DepSchemaName { get; set; }
        public string DepObjName { get; set; }
        public string DepObjType { get; set; }
    }
}
