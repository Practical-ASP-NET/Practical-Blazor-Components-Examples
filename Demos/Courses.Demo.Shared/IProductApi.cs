using Refit;

namespace Courses.Demo.Shared;

public interface IProductApi
{
    [Get("/product")]
    public Task<IEnumerable<Product>?> List();
}