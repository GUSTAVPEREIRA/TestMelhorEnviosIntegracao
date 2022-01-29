using Newtonsoft.Json;

namespace Core.Cart;

public class ShoppingCartAddressRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("document")]
    public string Document { get; set; }

    [JsonProperty("company_document")]
    public string CompanyDocument { get; set; }

    [JsonProperty("state_register")]
    public string StateRegister { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("complement")]
    public string Complement { get; set; }

    [JsonProperty("number")]
    public string Number { get; set; }

    [JsonProperty("district")]
    public string District { get; set; }

    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("country_id")]
    public string CountryId { get; set; }

    [JsonProperty("postal_code")]
    public string PostalCode { get; set; }

    [JsonProperty("note")]
    public string Note { get; set; }
}