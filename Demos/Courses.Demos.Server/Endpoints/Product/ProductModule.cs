using Carter;

namespace Courses.Demos.Server.Endpoints.Product;

public class ProductModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/product", GetAll);
    }

    private IResult GetAll(HttpContext context)
    {
        var products = Enumerable.Range(1, 10)
            .Select(i => new Demo.Shared.Product
            {
                Name = $"Product {i}",
                Description = $"Description {i}",
                Price = i * 10
            });

        return Results.Ok(products);
    }
}