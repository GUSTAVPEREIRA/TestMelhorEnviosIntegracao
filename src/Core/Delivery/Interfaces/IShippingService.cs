using Core.Delivery.Models;

namespace Core.Delivery.Interfaces;

public interface IShippingService
{
    public Task<List<CalculateShippingResponse>> ShippingCalculateAsync(ShippingRequest shippingRequest);
}