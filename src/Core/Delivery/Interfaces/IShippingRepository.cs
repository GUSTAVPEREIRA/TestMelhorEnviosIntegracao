using Core.Delivery.Models;

namespace Core.Delivery.Interfaces;

public interface IShippingRepository
{
    public Task<List<CalculateShippingResponse>> ShippingCalculateAsync(Shipping shippingRequest);
}