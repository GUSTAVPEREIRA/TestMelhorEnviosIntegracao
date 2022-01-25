using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateDimensionsResponse
{
    /// <example>2</example>
    [JsonProperty("height")]
    public decimal Height { get; set; }

    /// <example>11</example>
    [JsonProperty("width")]
    public decimal Width { get; set; }

    /// <example>16</example>
    [JsonProperty("length")]
    public decimal Length { get; set; }
}