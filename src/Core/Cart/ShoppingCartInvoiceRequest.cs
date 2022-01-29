using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartInvoiceRequest
{
    [JsonProperty("key")] 
    public string Key { get; set; }
}