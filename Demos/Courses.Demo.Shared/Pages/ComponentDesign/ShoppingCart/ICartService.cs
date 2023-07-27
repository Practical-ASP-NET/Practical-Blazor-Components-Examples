namespace Courses.Demo.Shared.Pages.ComponentDesign.ShoppingCart;

using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICartService
{
    Task<List<CartItem>> GetCartItemsAsync();
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class CartItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

    // Total price for the quantity of this product.
    public decimal TotalPrice => Quantity * Product.Price;
}