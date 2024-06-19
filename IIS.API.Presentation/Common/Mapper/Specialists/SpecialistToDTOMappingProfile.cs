using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Specialist;

namespace IIS.API.Presentation.Common.Mapper.Specialists;

public class SpecialistToDTOMappingProfile : Profile
{
    public SpecialistToDTOMappingProfile()
    {
        CreateMap<Specialist, SpecialistDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.Surname))
            .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(src => src.Patronymic))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position))
            .ForMember(dest => dest.CvUri, opt => opt.MapFrom(src => src.CvUri))
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUri))
            .ForMember(dest => dest.Desscription, opt => opt.MapFrom(src => src.Description));
    }
}
