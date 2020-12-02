﻿using DigitalSpeakerAssistant.Shared.Views;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DigitalSpeakerAssistant.Shared
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell
    {
        private readonly IRegionManager _regionManager;

        public Shell(IRegionManager regionManager)
        {
            this.InitializeComponent();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MainView));
            this._regionManager = regionManager;
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
            if (item.Tag.ToString() == "Customers")
            {
                _regionManager.RequestNavigate("ContentRegion", "CustomersView");
            }
        }

    }
}
