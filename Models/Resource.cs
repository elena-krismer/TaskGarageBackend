using System.ComponentModel.DataAnnotations;

namespace TaskGarageBackend.Models
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }        
        public required string Name { get; set; }
        public string? Type { get; set; }
        public int? Quantity { get; set; }
        public double? Cost { get; set; }

        public int WorkOrderId { get; set; }
    
    }
}