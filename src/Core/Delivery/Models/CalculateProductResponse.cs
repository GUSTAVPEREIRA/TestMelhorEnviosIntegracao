using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateProductResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}