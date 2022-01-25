namespace Core.Delivery.Models;

public class ShippingRequest
{
    /// <example>87080410</example>
    public string PostalCodeRequestFrom { get; set; }
    /// <example>19210000</example>
    public string PostalCodeRequestTo { get; set; }
    public List<ShippingProductRequest> ShippingProductRequests { get; set; }
}