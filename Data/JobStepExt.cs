using System;
using System.Collections.Generic;

#nullable disable

namespace BetlApp.Data
{
    public partial class JobStepExt
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public bool? JobEnabled { get; set; }
        public string CategoryName { get; set; }
        public string ScheduleName { get; set; }
        public int ScheduleEnabled { get; set; }
        public int? StepId { get; set; }
        public string StepName { get; set; }
        public string Subsystem { get; set; }
        public string Command { get; set; }
        public int? OnSuccessAction { get; set; }
        public int? OnSuccessStepId { get; set; }
        public int? OnFailAction { get; set; }
        public int? OnFailStepId { get; set; }
        public string DatabaseName { get; set; }
    }
}
