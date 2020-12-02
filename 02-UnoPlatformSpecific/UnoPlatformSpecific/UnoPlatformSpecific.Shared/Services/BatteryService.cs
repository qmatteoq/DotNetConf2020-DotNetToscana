using System;
using System.Collections.Generic;
using System.Text;

namespace UnoPlatformSpecific.Services
{
    public partial class BatteryService
    {
        public double BatteryLevel { get; set; }

        partial void GetBatteryLevelInternal();

        public double GetBatteryLevel()
        {
            GetBatteryLevelInternal();
            return BatteryLevel;
        }
    }
}
