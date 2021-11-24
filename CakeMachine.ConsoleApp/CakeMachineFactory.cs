﻿using CakeMachine.Dataflow.Settings;
using CakeMachine.Dataflow;
using System;

namespace CakeMachine.ConsoleApp
{
    public static class CakeMachineFactory
    {
        public static CakeMachineCooking GetCakeMachine(DurationType durationType)
        {
            switch (durationType)
            {
                case DurationType.Seconds:
                    var slowReportingDuration = new Duration(1, durationType);
                    var slowPrepareDuration = new Duration(5, 8, durationType);
                    var slowCookDuration = new Duration(10, durationType);
                    var slowPackageDuration = new Duration(2, durationType);
                    var slowDurationSettings = new DurationSettings(slowPrepareDuration, slowCookDuration, slowPackageDuration);
                    var slowReportingSettings = new ReportingSettings(slowReportingDuration, true);
                    var slowCakeMachineSettings = new CakeMachineSettings(slowDurationSettings, slowReportingSettings);
                    return new CakeMachineCooking(slowCakeMachineSettings);

                case DurationType.Milliseconds:
                    var fastReportingDuration = new Duration(100, durationType);
                    var fastPrepareDuration = new Duration(50, 80, durationType);
                    var fastCookDuration = new Duration(70, 90, durationType);
                    var fastPackageDuration = new Duration(30, durationType);
                    var fastDurationSettings = new DurationSettings(fastPrepareDuration, fastCookDuration, fastPackageDuration);
                    var fastReportingSettings = new ReportingSettings(fastReportingDuration, true);
                    var fastCakeMachineSettings = new CakeMachineSettings(fastDurationSettings, fastReportingSettings);
                    return new CakeMachineCooking(fastCakeMachineSettings);

                default:
                    throw new ArgumentOutOfRangeException($"{durationType}");
            }
        }
    }
}
