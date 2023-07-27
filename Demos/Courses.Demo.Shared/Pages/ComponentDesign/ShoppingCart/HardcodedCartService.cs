namespace Courses.Demo.Shared.Pages.ComponentDesign.ShoppingCart;

public class HardcodedCartService : ICartService
{
    private static readonly List<CartItem> CartItems = new List<CartItem>
    {
        new CartItem
        {
            Id = 1,
            Product = new Product { Id = 1, Name = "Product 1", Price = 9.99m },
            Quantity = 1
        },
        new CartItem
        {
            Id = 2,
            Product = new Product { Id = 2, Name = "Product 2", Price = 19.99m },
            Quantity = 2
        },
        new CartItem
        {
            Id = 3,
            Product = new Product { Id = 3, Name = "Product 3", Price = 29.99m },
            Quantity = 3
        }
    };
        
    public Task<List<CartItem>> GetCartItemsAsync()
    {
        // Simulate asynchronous operation
        return Task.FromResult(CartItems);
    }
        
    // Implement other methods like AddToCart, RemoveFromCart, UpdateQuantity etc.
}