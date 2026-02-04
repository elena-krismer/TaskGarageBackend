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

        // PATCH mapping: ignore nulls 
        CreateMap<WorkOrderUpdateDto, WorkOrder>()
            .ForAllMembers(opt =>
                opt.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<WorkOrderPutDto, WorkOrder>();

        // Vehicle
        CreateMap<Vehicle, VehicleReadDto>();
        CreateMap<VehicleCreateDto, Vehicle>();

        // PATCH mapping: ignore nulls 
        CreateMap<VehicleUpdateDto, Vehicle>()
            .ForAllMembers(opt =>
                opt.Condition((src, dest, srcMember) => srcMember != null));

        // Resource
        CreateMap<Resource, ResourceReadDto>();
        CreateMap<ResourceCreateDto, Resource>();

        CreateMap<ResourceUpdateDto, Resource>()
            .ForAllMembers(opt =>
                opt.Condition((src, dest, srcMember) => srcMember != null));
    }
}
