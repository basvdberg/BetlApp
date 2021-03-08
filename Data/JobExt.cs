using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class JobExt
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public bool? JobEnabled { get; set; }
        public string CategoryName { get; set; }
        public int? JobScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public int ScheduleEnabled { get; set; }
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
    }
}
