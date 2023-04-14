using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarbonProject.Shared.PostClass
{
    public class Flight
    {
        public Flight() { }

        [JsonPropertyName("type")] 
        public string Type { get;set; }

        [JsonPropertyName("passengers")]
        public string Passengers { get; set; }

        [JsonPropertyName("legs")]
        public Leg legs { get; set; }

    }

    public class Leg
    {
        [JsonPropertyName("departure_airport")]
        public string departure_airport { get; set; }

        [JsonPropertyName("destination_airport")]
        public string destination_airport { get; set; }
    }
}
