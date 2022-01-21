using Newtonsoft.Json;

namespace Core.Delivery;

public class ShippingProduct
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("width")]
    public decimal Width { get; set; }

    [JsonProperty("height")]
    public decimal Height { get; set; }

    [JsonProperty("length")]
    public decimal Length { get; set; }

    [JsonProperty("weight")]
    public decimal Weight { get; set; }

    [JsonProperty("insurance_value")]
    public decimal InsuranceValue { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}