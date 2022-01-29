using Newtonsoft.Json;

namespace Core.Cart.Models;

public class CartOrderResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("protocol")]
    public string Protocol { get; set; }

    [JsonProperty("service_id")]
    public int ServiceId { get; set; }

    [JsonProperty("agency_id")]
    public int AgencyId { get; set; }
    
    [JsonProperty("delivery_min")]
    public int DeliveryMin { get; set; }

    [JsonProperty("delivery_max")]
    public int DeliveryMax { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}