namespace Core.Cart.Models;

public class CartProductsRequest
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double UnitaryValue { get; set; }
}