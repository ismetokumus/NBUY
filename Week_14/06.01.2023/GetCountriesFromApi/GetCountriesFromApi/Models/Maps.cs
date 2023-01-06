using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonPropertyName("openStreatMaps")]
        public string OpenStreatMaps { get; set; }
    }
}