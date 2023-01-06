using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class CapitolInfo
    {
        [JsonPropertyName("latlng")]
        public double[] Latlng { get; set; }


    }
}