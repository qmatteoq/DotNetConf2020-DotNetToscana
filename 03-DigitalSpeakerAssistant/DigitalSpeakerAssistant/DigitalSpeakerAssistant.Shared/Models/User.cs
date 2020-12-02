using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace DigitalSpeakerAssistant.Shared.Models
{

    public class CustomersData
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public IEnumerable<Customer> Data { get; set; }

        [JsonProperty("support")]
        public Support Support { get; set; }
    }

    public class Support
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

}
