
using System.ComponentModel.DataAnnotations;
using TaskGarageBackend.Models;

namespace TaskGarageBackend.DTOs
{
    public class WorkOrderCreateDto
{
    public required string ClientName { get; set; }
    public required VehicleCreateDto VehicleInfo { get; set; }
    public required string Description { get; set; }
    public required DateTime CreationDate { get; set; }
    public DateTime? DeadlineDate { get; set; }
    public WorkOrderStatus Status { get; set; } = WorkOrderStatus.Pending;
    public List<ResourceCreateDto>? Resources { get; set; }
}


    public class WorkOrderReadDto
{
    public int Id { get; set; }
    public required string ClientName { get; set; } 
    public VehicleReadDto VehicleInfo { get; set; } = new();
    public string Description { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public DateTime? DeadlineDate { get; set; }
    public WorkOrderStatus Status { get; set; }
    public List<ResourceReadDto> Resources { get; set; } = new();
}


    public class WorkOrderUpdateDto
{
    public string? ClientName { get; set; }
    public VehicleUpdateDto? VehicleInfo { get; set; }
    public string? Description { get; set; }
    public DateTime? DeadlineDate { get; set; }
    public WorkOrderStatus? Status { get; set; }
    public List<ResourceUpdateDto>? Resources { get; set; }
}

    public class WorkOrderPutDto
{
    public string?ClientName { get; set; }
    public VehicleUpdateDto? VehicleInfo { get; set; }
    public string? Description { get; set; }
    public DateTime? DeadlineDate { get; set; }
    public WorkOrderStatus? Status { get; set; }
    public List<ResourceUpdateDto>? Resources { get; set; }
}





}