
using System.ComponentModel.DataAnnotations;
using TaskGarageBackend.Models;

namespace TaskGarageBackend.DTOs
{
    public class WorkOrderCreateDto
    {
       
        public required string ClientName { get; set; }

        public  required Vehicle VehicleInfo { get; set; }

        [MaxLength(500)]
        public required string Description { get; set; }

        public required DateTime DeadlineDate { get; set; }
    }
}