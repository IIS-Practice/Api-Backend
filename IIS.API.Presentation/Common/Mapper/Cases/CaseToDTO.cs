using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Case;

namespace IIS.API.Presentation.Common.Mapper.Cases;

public class CaseToDTO : Profile
{
    public CaseToDTO()
    {
        CreateMap<Case, CaseDTO>()
            .ForMember(cDTO => cDTO.Id,
                opt => opt.MapFrom(c => c.Id))
            .ForMember(cDTO => cDTO.Name,
                opt => opt.MapFrom(c => c.Name))
            .ForMember(cDTO => cDTO.Description,
                opt => opt.MapFrom(c => c.Description))
            .ForMember(cDTO => cDTO.Complexity,
                opt => opt.MapFrom(c => c.Complexity))
            .ForMember(cDTO => cDTO.Cost,
                opt => opt.MapFrom(c => c.Cost))
            .ForMember(cDTO => cDTO.StartDate,
                opt => opt.MapFrom(c => c.StartDate))
            .ForMember(cDTO => cDTO.EndDate,
                opt => opt.MapFrom(c => c.EndDate));

        CreateMap<Service, CaseDTO.InnerServiceDTO>()
            .ForMember(cDTO => cDTO.Id,
                opt => opt.MapFrom(c => c.Id))
            .ForMember(cDTO => cDTO.Name,
                opt => opt.MapFrom(c => c.Name));
    }
}
