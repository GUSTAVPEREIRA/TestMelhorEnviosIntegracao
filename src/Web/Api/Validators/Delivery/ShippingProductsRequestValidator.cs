using Core.Delivery.Models;
using FluentValidation;

namespace MelhorEnvios.Validators.Delivery;

public class ShippingProductsRequestValidator : AbstractValidator<ShippingProductRequest>
{
    public ShippingProductsRequestValidator()
    {
        RuleFor(x => x.Height).NotNull().NotEmpty();
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.Length).NotNull().NotEmpty();
        RuleFor(x => x.Quantity).NotNull().NotEmpty();
        RuleFor(x => x.Weight).NotNull().NotEmpty();
        RuleFor(x => x.Width).NotNull().NotEmpty();
        RuleFor(x => x.InsuranceValue).NotNull().NotEmpty();
    }
}