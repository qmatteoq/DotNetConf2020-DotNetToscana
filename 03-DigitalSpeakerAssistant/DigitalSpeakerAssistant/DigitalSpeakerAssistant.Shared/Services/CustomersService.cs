using DigitalSpeakerAssistant.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.Wasm;

namespace DigitalSpeakerAssistant.Shared.Services
{
    public class CustomersService : ICustomersService
    {
        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {

#if __WASM__
            HttpClient client = new HttpClient(new WasmHttpHandler());
#else
            HttpClient client = new HttpClient(new HttpClientHandler());
#endif
            string json = await client.GetStringAsync("https://reqres.in/api/users");
            var result = JsonConvert.DeserializeObject<CustomersData>(json);
            return result.Data;
        }
    }
}
