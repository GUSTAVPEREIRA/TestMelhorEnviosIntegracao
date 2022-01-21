using Core.Configurations.Extenstions;
using Core.Delivery;
using Core.Delivery.Interfaces;
using Core.Delivery.Models;
using Core.Request;
using Core.Request.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Infrastructure.Delivery;

public class ShippingRepository : IShippingRepository
{
    private readonly IHttpRequest _httpRequest;
    private readonly IConfiguration _configuration;

    public ShippingRepository(IHttpRequest httpRequest, IConfiguration configuration)
    {
        _httpRequest = httpRequest;
        _configuration = configuration;
    }

    public async Task<List<CalculateShippingResponse>> ShippingCalculateAsync(Shipping shippingRequest)
    {
        var settings = _configuration.GetSettings();

        var postHttpRequest = new PostHttpRequest
        {
            Url = settings.MelhorEnvios.Url + "/api/v2/me/shipment/calculate",
            Body = JsonConvert.SerializeObject(shippingRequest),
            Headers = new Dictionary<string, string> {{"Authorization", settings.MelhorEnvios.Token}}
        };
        
        var result = await _httpRequest.PostRequest(postHttpRequest);
        var calculateShippingResponse = JsonConvert.DeserializeObject<List<CalculateShippingResponse>>(result);

        return calculateShippingResponse;
    }
}