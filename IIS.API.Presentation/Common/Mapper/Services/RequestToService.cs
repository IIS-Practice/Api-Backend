using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Service;

namespace IIS.API.Presentation.Common.Mapper.Services;

public class RequestToService : Profile
{
    public RequestToService()
    {
        CreateMap<ServiceRequestDTO, Service>()
             .ForMember(s => s.Name,
                opt => opt.MapFrom(sDTO => sDTO.Name))
            .ForMember(s => s.Description,
                opt => opt.MapFrom(sDTO => sDTO.Description))
            .ForMember(s => s.Complexity,
                opt => opt.MapFrom(sDTO => sDTO.Complexity))
            .ForMember(s => s.Cost,
                opt => opt.MapFrom(sDTO => sDTO.Cost));
    }
}
