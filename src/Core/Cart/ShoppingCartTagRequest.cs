using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartTagRequest
{
    [JsonProperty("tag")]
    public string Tag { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}