namespace UnoPlatformSpecific.Services
{
    public partial class BatteryService
    {
        partial void GetBatteryLevelInternal()
        {
            BatteryLevel = Xamarin.Essentials.Battery.ChargeLevel * 100;
        }
    }
}