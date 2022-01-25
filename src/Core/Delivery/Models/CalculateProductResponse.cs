using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateProductResponse
{
    /// <example>1</example>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <example>1</example>
    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}