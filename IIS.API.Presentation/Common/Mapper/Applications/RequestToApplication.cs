using AutoMapper;
using IIS.API.Presentation.Common.Models.Application;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Presentation.Common.Mapper.Applications;

public class RequestToApplication : Profile
{
    public RequestToApplication()
    {
        CreateMap<ApplicationRequestDTO, DomainApplication>()
            .ForMember(a => a.Author,
                opt => opt.MapFrom(aDTO => aDTO.Author))
            .ForMember(a => a.Email,
                opt => opt.MapFrom(aDTO => aDTO.Email))
            .ForMember(a => a.PhoneNumber,
                opt => opt.MapFrom(aDTO => aDTO.PhoneNumber))
            .ForMember(a => a.Description,
                opt => opt.MapFrom(aDTO => aDTO.Description));
    }
}
