using AutoMapper;
using IIS.API.Presentation.Common.Models.Application;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Presentation.Common.Mapper.Applications;

public class ApplicationToDTO : Profile
{
    public ApplicationToDTO()
    {
        CreateMap<DomainApplication, ApplicationDTO>()
            .ForMember(aDTO => aDTO.Id,
                opt => opt.MapFrom(a => a.Id))
            .ForMember(aDTO => aDTO.Author,
                opt => opt.MapFrom(a => a.Author))
            .ForMember(aDTO => aDTO.Email,
                opt => opt.MapFrom(a => a.Email))
            .ForMember(aDTO => aDTO.PhoneNumber,
                opt => opt.MapFrom(a => a.PhoneNumber))
            .ForMember(aDTO => aDTO.Description,
                opt => opt.MapFrom(a => a.Description))
            .ForMember(aDTO => aDTO.Date,
                opt => opt.MapFrom(a => a.Date));
    }
}
