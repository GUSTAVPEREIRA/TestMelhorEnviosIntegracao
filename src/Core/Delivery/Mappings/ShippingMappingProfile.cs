using AutoMapper;
using Core.Delivery.Models;

namespace Core.Delivery.Mappings;

public class ShippingMappingProfile : Profile
{
    public ShippingMappingProfile()
    {
        CreateMap<ShippingRequest, Shipping>().BeforeMap((shippingRequest, shipping) =>
        {
            shipping.ShippingPostalFrom = new ShippingPostalCode
            {
                PostalCode = shippingRequest.PostalCodeRequestFrom
            };

            shipping.ShippingPostalTo = new ShippingPostalCode
            {
                PostalCode = shippingRequest.PostalCodeRequestTo
            };

            var count = shippingRequest.ShippingProductRequests.Count;

            if (count > 0)
            {
                shipping.Products = new List<ShippingProduct>(count);

                foreach (var request in shippingRequest.ShippingProductRequests)
                {
                    shipping.Products.Add(new ShippingProduct()
                    {
                        Length = request.Length,
                        Height = request.Quantity,
                        Id = request.Id,
                        Quantity = request.Quantity,
                        Weight = request.Weight,
                        Width = request.Width,
                        InsuranceValue = request.InsuranceValue
                    });
                }
            }
        });
    }
}