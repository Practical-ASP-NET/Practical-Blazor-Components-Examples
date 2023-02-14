namespace Courses.Demos.Pages.PurchaseOrderDashboard.Models;

public class PurchaseOrderStore
{
    private readonly List<PurchaseOrder> _purchaseOrders = new();

    public PurchaseOrderStore()
    {
        Seed();
    }

    private void Seed(bool replace = false)
    {
        if(replace)
            _purchaseOrders.Clear();
        
        _purchaseOrders.Add(new PurchaseOrder
        {
            Id = Guid.Parse("0afe6b57-561f-4ff3-9628-e4c613b67f3f"),
            Lines = new List<PurchaseOrder.Line>
            {
                new() { Id = Guid.NewGuid(), Quantity = 10, Description = "Widget A", Rate = 14.50 },
                new() { Id = Guid.NewGuid(), Quantity = 5, Description = "Widget B", Rate = 12.30 },
                new() { Id = Guid.NewGuid(), Quantity = 5, Description = "Widget C", Rate = 18.10 },
            }
        });
    }

    public IEnumerable<PurchaseOrder> ListAll()
    {
        return _purchaseOrders;
    }

    public PurchaseOrder Get(Guid Id)
    {
        return _purchaseOrders.FirstOrDefault(x => x.Id == Id);
    }

    public void ReceiveMaterial(Guid orderId, Guid lineId)
    {
        var po = _purchaseOrders.FirstOrDefault(x => x.Id == orderId);
        po.ReceiveMaterial(lineId);
    }

    public void Reset()
    {
        Seed(true);
    }
}