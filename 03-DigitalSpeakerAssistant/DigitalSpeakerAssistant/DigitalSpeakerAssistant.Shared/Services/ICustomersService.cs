using DigitalSpeakerAssistant.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSpeakerAssistant.Shared.Services
{
    public interface ICustomersService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
