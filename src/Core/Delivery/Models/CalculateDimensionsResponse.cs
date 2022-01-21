using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateDimensionsResponse
{
    [JsonProperty("height")]
    public decimal Height { get; set; }

    [JsonProperty("width")]
    public decimal Width { get; set; }

    [JsonProperty("length")]
    public decimal Length { get; set; }
}