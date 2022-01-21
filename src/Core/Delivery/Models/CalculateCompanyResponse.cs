using Newtonsoft.Json;

namespace Core.Delivery.Models;

public class CalculateCompanyResponse
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("picture")]
    public string Picture { get; set; }
}