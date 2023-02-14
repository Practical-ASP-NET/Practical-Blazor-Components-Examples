namespace Courses.Demos.Pages.PurchaseOrderDashboard.Models;

public class PurchaseOrder
{
    public Guid Id { get; set; }
    
    public IEnumerable<Line> Lines { get; set; }

    public void ReceiveMaterial(Guid lineId)
    {
        // important business rules here!
        var line = Lines.FirstOrDefault(x => x.Id == lineId);
        if (line == null)
            throw new Exception("Could not find purchase order line");
        line.Received = true;
    }
    
    public class Line
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public bool Received { get; set; }
    }
}