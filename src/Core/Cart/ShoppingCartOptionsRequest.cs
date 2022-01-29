using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartOptionsRequest
{
    [JsonProperty("insurance_value")]
    public double InsuranceValue { get; set; }

    [JsonProperty("receipt")]
    public bool Receipt { get; set; }

    [JsonProperty("own_hand")]
    public bool OwnHand { get; set; }

    [JsonProperty("reverse")]
    public bool Reverse { get; set; }

    [JsonProperty("non_commercial")]
    public bool NonCommercial { get; set; }

    [JsonProperty("invoice")]
    public ShoppingCartInvoiceRequest InvoiceRequest { get; set; }

    [JsonProperty("platform")]
    public string Platform { get; set; }

    [JsonProperty("tags")]
    public List<ShoppingCartTagRequest> Tags { get; set; }
}