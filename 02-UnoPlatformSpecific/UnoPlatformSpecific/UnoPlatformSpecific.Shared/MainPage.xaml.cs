using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnoPlatformSpecific.Services;
using Windows.Devices.Geolocation;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoPlatformSpecific
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public async void OnGetPosition(object sender, RoutedEventArgs e)
        {
            Geolocator locator = new Geolocator();
            var status = await Geolocator.RequestAccessAsync();
            if (status == GeolocationAccessStatus.Allowed)
            {
                GeolocationLoading.IsActive = true;
                var result = await locator.GetGeopositionAsync();
                GeolocationLoading.IsActive = false;
                txtCoordinates.Text = $"Coordinates: {result.Coordinate.Point.Position.Latitude} / {result.Coordinate.Point.Position.Longitude}";
            }
        }

        public async void OnSaveFile(object sender, RoutedEventArgs e)
        {
            var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("sample.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, "Hello from Uno!");
            ApplicationData.Current.LocalSettings.Values["MySetting"] = "Hello world";
        }

        public async void OnReadFile(object sender, RoutedEventArgs e)
        {
            var file = await ApplicationData.Current.LocalFolder.GetFileAsync("sample.txt");
            string text = await FileIO.ReadTextAsync(file);
            txtFileContent.Text = text;
        }

        public void OnGetBattery(object sender, RoutedEventArgs e)
        {
#if NETFX_CORE
            var aggBattery = Battery.AggregateBattery;
            var report = aggBattery.GetReport();
            txtBatteryStatus.Text = report.RemainingCapacityInMilliwattHours.Value.ToString();

#elif __ANDROID__
                        txtBatteryStatus.Text = Xamarin.Essentials.Battery.ChargeLevel.ToString();
#endif
            //BatteryService battery = new BatteryService();
            //double batteryLevel = battery.GetBatteryLevel();
            //txtBatteryStatus.Text = batteryLevel.ToString();

        }
    }
}
