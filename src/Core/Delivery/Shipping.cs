using Newtonsoft.Json;

namespace Core.Delivery;

public class Shipping
{
    [JsonProperty("from")] public ShippingPostalCode ShippingPostalFrom { get; set; }

    [JsonProperty("to")] public ShippingPostalCode ShippingPostalTo { get; set; }

    [JsonProperty("products")] public List<ShippingProduct> Products { get; set; }
}