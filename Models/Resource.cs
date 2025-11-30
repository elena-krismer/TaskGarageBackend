namespace TaskGarageBackend.Models
{
    public class Resource
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Type { get; set; }
        public int? Quantity { get; set; }
        public double? Cost { get; set; }

        public int? WorkOrderId { get; set; }
        public WorkOrder? WorkOrder { get; set; }
    }
}