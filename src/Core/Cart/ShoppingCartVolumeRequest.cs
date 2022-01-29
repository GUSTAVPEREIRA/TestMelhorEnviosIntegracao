using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartVolumeRequest
{
    [JsonProperty("height")]
    public int Height { get; set; }

    [JsonProperty("width")]
    public int Width { get; set; }

    [JsonProperty("length")]
    public int Length { get; set; }

    [JsonProperty("weight")]
    public double Weight { get; set; }
}