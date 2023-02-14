using Carter;
using Courses.Demos.Pages.PurchaseOrderDashboard.Models;

namespace Courses.Demos.Server.Endpoints.PurchaseOrder;

public class PurchaseOrderModule : CarterModule
{

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/purchaseorder", GetAll);
        app.MapPut("/purchaseorder/reset", Reset);
        app.MapGet("/purchaseorder/{id}", Get);
        app.MapPut("/purchaseorder/{id}/lines/{lineId}/receive", MarkLineAsReceived);
    }

    private IResult Reset(HttpContext context, PurchaseOrderStore purchaseOrderStore)
    {
        purchaseOrderStore.Reset();
        return Results.Ok();
    }

    private IResult MarkLineAsReceived(HttpContext context, PurchaseOrderStore purchaseOrderStore, Guid id, Guid lineId)
    {
        purchaseOrderStore.ReceiveMaterial(id, lineId);
        return Results.Ok();
    }

    private IResult Get(HttpContext context,PurchaseOrderStore purchaseOrderStore, Guid id)
    {
        return Results.Ok(purchaseOrderStore.Get(id));
    }

    private IResult GetAll(HttpContext context, PurchaseOrderStore purchaseOrderStore)
    {
        return Results.Ok(purchaseOrderStore.ListAll());
    }
}