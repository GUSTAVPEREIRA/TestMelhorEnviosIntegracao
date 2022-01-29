using AutoMapper;
using Core.Delivery;
using Core.Delivery.Interfaces;
using Core.Delivery.Models;

namespace Application.Delivery;

public class ShippingService : IShippingService
{
    private readonly IShippingRepository _shippingRepository;
    private readonly IMapper _mapper;

    public ShippingService(IShippingRepository shippingRepository, IMapper mapper)
    {
        _shippingRepository = shippingRepository;
        _mapper = mapper;
    }

    public async Task<List<CalculateShippingResponse>> ShippingCalculateAsync(ShippingRequest shippingRequest)
    {
        var shipping = _mapper.Map<Shipping>(shippingRequest);

        return await _shippingRepository.ShippingCalculateAsync(shipping);
    }
}