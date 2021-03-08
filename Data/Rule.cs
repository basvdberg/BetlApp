using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Rule
    {
        public Rule()
        {
            RuleMappings = new HashSet<RuleMapping>();
        }

        public int RuleId { get; set; }
        public string RuleDescription { get; set; }
        public string RuleRationale { get; set; }
        public string RuleSqlExample { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual ICollection<RuleMapping> RuleMappings { get; set; }
    }
}
