using DigitalSpeakerAssistant.Shared.Models;
using DigitalSpeakerAssistant.Shared.Services;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DigitalSpeakerAssistant.Shared.ViewModels
{
    public class CustomersViewModel: BindableBase, Prism.Regions.INavigationAware
    {
        private List<Customer> _customers;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { SetProperty(ref _customers, value); }
        }

        private readonly ICustomersService _customerService;

        public CustomersViewModel(ICustomersService customerService)
        {
            this._customerService = customerService;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            var result = await _customerService.GetCustomersAsync();
            Customers = new List<Customer>(result);
            Debug.WriteLine(Customers.Count);
        }
    }
}
