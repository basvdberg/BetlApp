using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class ObjTransfer
    {
        public string SchemaName { get; set; }
        public int ObjId { get; set; }
        public string FullObjName { get; set; }
        public string ObjType { get; set; }
        public DateTime? MaxTransferDt { get; set; }
    }
}
