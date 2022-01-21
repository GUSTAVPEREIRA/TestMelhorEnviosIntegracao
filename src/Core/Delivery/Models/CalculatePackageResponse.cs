using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculatePackageResponse
{
    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("discount")]
    public string Discount { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("dimensions")]
    public CalculateDimensionsResponse Dimensions { get; set; }

    [JsonProperty("weight")]
    public string Weight { get; set; }

    [JsonProperty("insurance_value")]
    public string InsuranceValue { get; set; }

    [JsonProperty("products")]
    public List<CalculateProductResponse> Products { get; set; }
}