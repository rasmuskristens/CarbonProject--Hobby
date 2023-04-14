using System.Text.Json.Serialization;

namespace CarbonProject.Shared
{

    public class Attributes
    {
        public int passengers { get; set; }
        public List<Leg> legs { get; set; }
        public double distance_value { get; set; }
        public string distance_unit { get; set; }
        public DateTime estimated_at { get; set; }
        public int carbon_g { get; set; }
        public double carbon_lb { get; set; }
        public double carbon_kg { get; set; }
        public double carbon_mt { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string electricity_unit { get; set; }
        public double? electricity_value { get; set; }
        public string vehicle_make { get; set; }
        public string vehicle_model { get; set; }
        public int? vehicle_year { get; set; }
        public string vehicle_model_id { get; set; }
        public string weight_unit { get; set; }
        public string transport_method { get; set; }
        public double? weight_value { get; set; }
        public string fuel_source_type { get; set; }
        public string fuel_source_unit { get; set; }
        public double? fuel_source_value { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Leg
    {
        public string departure_airport { get; set; }
        public string destination_airport { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
    }

}