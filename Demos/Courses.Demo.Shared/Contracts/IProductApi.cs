using Refit;

namespace Courses.Demo.Shared.Contracts;

public interface IProductApi
{
    [Get("/product")]
    public Task<IEnumerable<Product>?> List();
}