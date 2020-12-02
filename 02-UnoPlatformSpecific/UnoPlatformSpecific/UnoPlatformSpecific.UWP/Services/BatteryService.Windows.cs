using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Power;

namespace UnoPlatformSpecific.Services
{
    public partial class BatteryService
    {
        partial void GetBatteryLevelInternal()
        {
            var aggBattery = Battery.AggregateBattery;
            var report = aggBattery.GetReport();
            BatteryLevel = report.RemainingCapacityInMilliwattHours.Value;
        }

    }
}
