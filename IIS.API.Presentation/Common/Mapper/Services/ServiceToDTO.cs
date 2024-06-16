using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Service;

namespace IIS.API.Presentation.Common.Mapper.Services;

public class ServiceToDTO : Profile
{
    public ServiceToDTO() 
    {
        CreateMap<Service, ServiceDTO>()
            .ForMember(sDTO => sDTO.Id,
                opt => opt.MapFrom(s => s.Id))
            .ForMember(sDTO => sDTO.Name,
                opt => opt.MapFrom(s => s.Name))
            .ForMember(sDTO => sDTO.Description,
                opt => opt.MapFrom(s => s.Description))
            .ForMember(sDTO => sDTO.Complexity,
                opt => opt.MapFrom(s => s.Complexity))
            .ForMember(sDTO => sDTO.Cost,
                opt => opt.MapFrom(s => s.Cost));

        CreateMap<Case, ServiceDTO.InnerCaseDTO>()
            .ForMember(cDTO => cDTO.Id,
                opt => opt.MapFrom(c => c.Id))
            .ForMember(cDTO => cDTO.Name,
                opt => opt.MapFrom(c => c.Name));

        CreateMap<Specialist, ServiceDTO.InnerSpecialistDTO>()
            .ForMember(sDTO => sDTO.Id,
                opt => opt.MapFrom(s => s.Id))
            .ForMember(sDTO => sDTO.FullName,
                opt => opt.MapFrom(s => $"{s.Name} {s.Surname} {s.Patronymic}"));
    }

}
