using Core.Delivery.Models;
using FluentValidation;

namespace MelhorEnvios.Validators.Delivery;

public class ShippingRequestValidator : AbstractValidator<ShippingRequest>
{
    public ShippingRequestValidator()
    {
        RuleForEach(x => x.ShippingProductRequests).SetValidator(new ShippingProductsRequestValidator());
        RuleFor(x => x.PostalCodeRequestFrom).NotNull().NotEmpty().MinimumLength(8).MaximumLength(8);
        RuleFor(x => x.PostalCodeRequestTo).NotNull().NotEmpty().MinimumLength(8).MaximumLength(8);
    }
}