using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartProductRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }

    [JsonProperty("unitary_value")]
    public double UnitaryValue { get; set; }
}