using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateCustomDeliveryRangeResponse
{
    /// <example>9</example>
    [JsonProperty("min")]
    public int Min { get; set; }

    /// <example>11</example>
    [JsonProperty("max")]
    public int Max { get; set; }
}