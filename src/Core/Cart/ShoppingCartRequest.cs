using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartRequest
{
    [JsonProperty("service")]
    public int Service { get; set; }

    [JsonProperty("agency")]
    public int Agency { get; set; }

    [JsonProperty("from")]
    public ShoppingCartAddressRequest From { get; set; }

    [JsonProperty("to")]
    public ShoppingCartAddressRequest To { get; set; }

    [JsonProperty("products")]
    public List<ShoppingCartProductRequest> Products { get; set; }

    [JsonProperty("volumes")]
    public List<ShoppingCartVolumeRequest> Volumes { get; set; }

    [JsonProperty("options")]
    public ShoppingCartOptionsRequest OptionsRequest { get; set; }
}