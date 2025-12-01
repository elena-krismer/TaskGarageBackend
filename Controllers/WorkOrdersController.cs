using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskGarageBackend.Data;
using TaskGarageBackend.Models;
using TaskGarageBackend.DTOs;
using AutoMapper;


namespace TaskGarageBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkOrdersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public WorkOrdersController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorkOrder(WorkOrderCreateDto dto)
        {
            var workOrder = _mapper.Map<WorkOrder>(dto);

            workOrder.CreationDate = DateTime.UtcNow;

            _context.WorkOrders.Add(workOrder);
            await _context.SaveChangesAsync();

            return Ok(_mapper.Map<WorkOrderReadDto>(workOrder));
        }


    // GET: api/workorders
    [HttpGet]
    public async Task<ActionResult<IEnumerable<WorkOrderReadDto>>> GetWorkOrders()
    {
        var orders = await _context.WorkOrders
            .Include(o => o.VehicleInfo)
            .Include(o => o.Resources)
            .ToListAsync();

        return Ok(_mapper.Map<List<WorkOrderReadDto>>(orders));
    }

    // GET: api/workorders/5
    [HttpGet("{id}")]
    public async Task<ActionResult<WorkOrderReadDto>> GetWorkOrder(int id)
    {
        var order = await _context.WorkOrders
            .FirstOrDefaultAsync(o => o.Id == id);

        if (order == null)
            return NotFound();

        return _mapper.Map<WorkOrderReadDto>(order);
    
    }

    // PUT: api/workorders/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateWorkOrder(int id,  WorkOrderPutDto dto)
    {
        var workOrder = await _context.WorkOrders
            .Include(w => w.VehicleInfo)
            .Include(w => w.Resources)
            .FirstOrDefaultAsync(w => w.Id == id);

        if (workOrder == null)
            return NotFound();

        _mapper.Map(dto, workOrder);

        await _context.SaveChangesAsync();

        return Ok(_mapper.Map<WorkOrderReadDto>(workOrder));
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchWorkOrder(int id, WorkOrderUpdateDto dto)
        {
            var workOrder = await _context.WorkOrders
                .Include(w => w.VehicleInfo)
                .Include(w => w.Resources)
                .FirstOrDefaultAsync(w => w.Id == id);

            if (workOrder == null)
                return NotFound();

            _mapper.Map(dto, workOrder);

            await _context.SaveChangesAsync();

            return Ok(_mapper.Map<WorkOrderReadDto>(workOrder));
        }
    }
}