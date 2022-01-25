using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateCompanyResponse
{
    /// <example>1</example>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <example>Correios</example>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <example>https://sandbox.melhorenvio.com.br/images/shipping-companies/correios.png</example>
    [JsonProperty("picture")]
    public string Picture { get; set; }
}