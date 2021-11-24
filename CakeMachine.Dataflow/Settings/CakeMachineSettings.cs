using CakeMachine.Dataflow.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace CakeMachine.Dataflow.Settings
{
    public class CakeMachineSettings
    {
        public DurationSettings DurationSettings { get; }

        public ReportingSettings ReportingSettings { get; }

        public ParallelismSettings ParallelismSettings { get; set; }

        public CakeMachineSettings(DurationSettings durationSettings, ReportingSettings reportingSettings)
        {
            DurationSettings = durationSettings;
            ReportingSettings = reportingSettings;
            ParallelismSettings = new ParallelismSettings();
        }
    }
}
