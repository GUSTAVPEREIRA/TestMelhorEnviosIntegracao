using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculatePackageResponse
{
    /// <example>55.20</example>
    [JsonProperty("price")]
    public string Price { get; set; }

    /// <example>10.20</example>
    [JsonProperty("discount")]
    public string Discount { get; set; }

    /// <example>box</example>
    [JsonProperty("format")]
    public string Format { get; set; }
    
    [JsonProperty("dimensions")]
    public CalculateDimensionsResponse Dimensions { get; set; }

    /// <example>10.00</example>
    [JsonProperty("weight")]
    public string Weight { get; set; }

    /// <example>10.00</example>
    [JsonProperty("insurance_value")]
    public string InsuranceValue { get; set; }

    [JsonProperty("products")]
    public List<CalculateProductResponse> Products { get; set; }
}