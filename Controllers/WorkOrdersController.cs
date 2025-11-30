using Microsoft.AspNetCore.Mvc;
using TaskGarageBackend.Data;
using TaskGarageBackend.Models;
using TaskGarageBackend.DTOs;


namespace TaskGarageBackend.Controllers
{
    

[ApiController]
[Route("api/[controller]")]
public class WorkOrdersController : ControllerBase
{
    private readonly AppDbContext _context;

    public WorkOrdersController(AppDbContext context)
    {
        _context = context;
    }

   [HttpPost]
public async Task<IActionResult> CreateWorkOrder([FromBody] WorkOrderCreateDto dto)
{
    var vehicle = new Vehicle
    {
        Brand = dto.VehicleInfo.Brand,
        Model = dto.VehicleInfo.Model,
        LicensePlate = dto.VehicleInfo.LicensePlate
    };

    var workOrder = new WorkOrder
    {
        ClientName = dto.ClientName,
        VehicleInfo = vehicle,
        Description = dto.Description,
        DeadlineDate = dto.DeadlineDate,
        Status = WorkOrderStatus.Pending
    };

    _context.WorkOrders.Add(workOrder);
    await _context.SaveChangesAsync();

    return Ok(workOrder);
}

}
}