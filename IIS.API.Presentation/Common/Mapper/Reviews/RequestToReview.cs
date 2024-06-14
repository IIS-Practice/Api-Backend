using AutoMapper;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Review;

namespace IIS.API.Presentation.Common.Mapper.Reviews;

public class RequestToReview : Profile
{
    public RequestToReview()
    {
        CreateMap<ReviewRequestDTO, Review>()
            .ForMember(review => review.Text,
                opt => opt.MapFrom(reviewRequestDTO => reviewRequestDTO.Text))
            .ForMember(review => review.Date,
                opt => opt.MapFrom(reviewRequestDTO => reviewRequestDTO.Date))
            .ForMember(review => review.UserId,
                opt => opt.MapFrom(reviewRequestDTO => reviewRequestDTO.UserId));
    }
}

