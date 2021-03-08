using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class Job
    {
        public Job()
        {
            JobSteps = new HashSet<JobStep>();
        }

        public int JobId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }
        public string CategoryName { get; set; }
        public int? JobScheduleId { get; set; }
        public DateTime? RecordDt { get; set; }
        public string RecordUser { get; set; }

        public virtual JobSchedule JobSchedule { get; set; }
        public virtual ICollection<JobStep> JobSteps { get; set; }
    }
}
