using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateDeliveryRangeResponse
{
    [JsonProperty("min")]
    public int Min { get; set; }

    [JsonProperty("max")]
    public int Max { get; set; }
}