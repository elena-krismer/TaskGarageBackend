using System.ComponentModel.DataAnnotations;

namespace TaskGarageBackend.Models
{
    public enum WorkOrderStatus
    {
        Pending,       
        InProgress,   
        Finished,      
        Problem      
    }

    public class WorkOrder
    {
        [Key]
        public int Id { get; set; }
        public required string ClientName { get; set; }
        public required Vehicle VehicleInfo { get; set; }
        public string? Description { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public WorkOrderStatus? Status { get; set; } = WorkOrderStatus.Pending;
        public List<Resource>? Resources { get; set; }
    }
}