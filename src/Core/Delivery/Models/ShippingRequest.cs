namespace Core.Delivery.Models;

public class ShippingRequest
{
    public string PostalCodeRequestFrom { get; set; }
    public string PostalCodeRequestTo { get; set; }
    public List<ShippingProductRequest> ShippingProductRequests { get; set; }
}