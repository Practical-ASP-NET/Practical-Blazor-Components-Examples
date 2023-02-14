using Courses.Demos.Pages.PurchaseOrderDashboard.Models;
using Refit;

namespace Courses.Demo.Shared;

public interface IPurchaseOrderAPI
{
    [Get("/purchaseorder")]
    public Task<IEnumerable<PurchaseOrder>> List();
    
    [Get("/purchaseorder/{id}")]
    public Task<PurchaseOrder> Get(Guid id);
    
    [Put("/purchaseorder/{id}/lines/{lineId}/receive")]
    public Task ReceiveMaterial(Guid id, Guid lineId);

    [Put("/purchaseorder/reset")]
    public Task Reset();
}