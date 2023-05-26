using Courses.Demo.Shared.Contracts;
using Courses.Demo.Shared.Pages.PurchaseOrderDashboard.Models;

namespace Courses.Demos.Server;

public class PurchaseOrderAPI : IPurchaseOrderAPI
{
    private readonly PurchaseOrderStore _store;

    public PurchaseOrderAPI(PurchaseOrderStore store)
    {
        _store = store;
    }
    
    public Task<IEnumerable<PurchaseOrder>> List()
    {
        return Task.FromResult(_store.ListAll());
    }

    public Task<PurchaseOrder> Get(Guid id)
    {
        return Task.FromResult(_store.Get(id));
    }

    public Task ReceiveMaterial(Guid id, Guid lineId)
    {
        _store.ReceiveMaterial(id, lineId);
        return Task.CompletedTask;
    }

    public Task Reset()
    {
       _store.Reset();
       return Task.CompletedTask;
    }
}