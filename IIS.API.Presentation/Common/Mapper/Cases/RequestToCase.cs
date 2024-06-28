using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Case;

namespace IIS.API.Presentation.Common.Mapper.Cases;

public class RequestToCase : Profile
{
    public RequestToCase()
    {
        CreateMap<CaseRequestDTO, Case>()
            .ForMember(c => c.Name,
                opt => opt.MapFrom(cDTO => cDTO.Name))
            .ForMember(c => c.ShortDescription,
                opt => opt.MapFrom(cDTO => cDTO.ShortDescription))
            .ForMember(c => c.Description,
                opt => opt.MapFrom(cDTO => cDTO.InnerHtml))
            .ForMember(c => c.Complexity,
                opt => opt.MapFrom(cDTO => cDTO.Complexity))
            .ForMember(c => c.Cost,
                opt => opt.MapFrom(cDTO => cDTO.Cost))
            .ForMember(c => c.StartDate,
                opt => opt.MapFrom(cDTO => cDTO.StartDate))
            .ForMember(c => c.EndDate,
                opt => opt.MapFrom(cDTO => cDTO.EndDate));
    }

}
