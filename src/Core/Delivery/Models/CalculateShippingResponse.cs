using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateShippingResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("custom_price")]
    public string CustomPrice { get; set; }

    [JsonProperty("discount")]
    public string Discount { get; set; }

    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("delivery_time")]
    public int DeliveryTime { get; set; }

    [JsonProperty("delivery_range")]
    public CalculateDeliveryRangeResponse DeliveryRange { get; set; }

    [JsonProperty("custom_delivery_time")]
    public int CustomDeliveryTime { get; set; }

    [JsonProperty("custom_delivery_range")]
    public CalculateCustomDeliveryRangeResponse CustomDeliveryRange { get; set; }

    [JsonProperty("packages")]
    public List<CalculatePackageResponse> Packages { get; set; }

    [JsonProperty("company")]
    public CalculateCompanyResponse Company { get; set; }

    [JsonProperty("error")]
    public string Error { get; set; }
}