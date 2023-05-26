using Courses.Demo.Shared.Contracts;

namespace Courses.Demos.Server.Clients;

public class ProductAPI : IProductApi
{
    public Task<IEnumerable<Product>?> List()
    {
        var products = Enumerable.Range(1, 10)
            .Select(i => new Product
            {
                Name = $"Product {i}",
                Description = $"Description {i}",
                Price = i * 10,
                Featured = i == 1
            });

        return Task.FromResult(products)!;
    }
}