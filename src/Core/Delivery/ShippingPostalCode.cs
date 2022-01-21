using Newtonsoft.Json;

namespace Core.Delivery;

public class ShippingPostalCode
{
    [JsonProperty("postal_code")]
    public string PostalCode { get; set; }
}