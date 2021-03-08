using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class JobSchedule
    {
        public JobSchedule()
        {
            Jobs = new HashSet<Job>();
        }

        public int JobScheduleId { get; set; }
        public string Name { get; set; }
        public int Enabled { get; set; }
        public int FreqType { get; set; }
        public int FreqInterval { get; set; }
        public int FreqSubdayType { get; set; }
        public int FreqSubdayInterval { get; set; }
        public int FreqRelativeInterval { get; set; }
        public int FreqRecurrenceFactor { get; set; }
        public int ActiveStartDate { get; set; }
        public int ActiveEndDate { get; set; }
        public int ActiveStartTime { get; set; }
        public int ActiveEndTime { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
