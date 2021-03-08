using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Template
    {
        public short TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateCode { get; set; }
        public string TemplateDescription { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordName { get; set; }
    }
}
