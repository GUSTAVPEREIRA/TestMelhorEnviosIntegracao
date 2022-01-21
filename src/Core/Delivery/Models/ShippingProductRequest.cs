namespace Core.Delivery.Models;

public class ShippingProductRequest
{
    /// <example>1</example>
    public string Id { get; set; }

    /// <example>10</example>
    public decimal Width { get; set; }

    /// <example>10</example>
    public decimal Height { get; set; }

    /// <example>10</example>
    public decimal Length { get; set; }

    /// <example>10</example>
    public decimal Weight { get; set; }

    /// <example>10</example>
    public decimal InsuranceValue { get; set; }

    /// <example>1</example>
    public int Quantity { get; set; }
}