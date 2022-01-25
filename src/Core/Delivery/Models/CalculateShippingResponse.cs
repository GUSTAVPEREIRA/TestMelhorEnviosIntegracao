using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateShippingResponse
{
    /// <example>1</example>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <example>PAC</example>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <example>55.20</example>
    [JsonProperty("price")]
    public string Price { get; set; }

    /// <example>55.20</example>
    [JsonProperty("custom_price")]
    public string CustomPrice { get; set; }

    /// <example>10.20</example>
    [JsonProperty("discount")]
    public string Discount { get; set; }

    /// <example>R$</example>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    /// <example>11</example>
    [JsonProperty("delivery_time")]
    public int DeliveryTime { get; set; }
    
    [JsonProperty("delivery_range")]
    public CalculateDeliveryRangeResponse DeliveryRange { get; set; }

    /// <example>11</example>
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