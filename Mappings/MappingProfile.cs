using AutoMapper;
using TaskGarageBackend.Models;
using TaskGarageBackend.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // WorkOrder
        CreateMap<WorkOrder, WorkOrderReadDto>();
        CreateMap<WorkOrderCreateDto, WorkOrder>();
        CreateMap<WorkOrderUpdateDto, WorkOrder>();

        // Vehicle
        CreateMap<Vehicle, VehicleReadDto>();
        CreateMap<VehicleCreateDto, Vehicle>();
        CreateMap<VehicleUpdateDto, Vehicle>();

        // Resource
        CreateMap<Resource, ResourceReadDto>();
        CreateMap<ResourceCreateDto, Resource>();
    }
}
