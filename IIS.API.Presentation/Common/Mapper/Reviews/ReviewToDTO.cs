using AutoMapper;
using IIS.API.Presentation.Common.Models.Review;
using IIS.API.Domain.Entities;

namespace IIS.API.Presentation.Common.Mapper.Reviews;

public class ReviewToDTO : Profile
{
    public ReviewToDTO()
    {
        CreateMap<Review, ReviewDTO>()
            .ForMember(reviewDTO => reviewDTO.ReviewId, opt => opt.MapFrom(review => review.Id))
            .ForMember(reviewDTO => reviewDTO.Text, opt => opt.MapFrom(review => review.Text))
            .ForMember(reviewDTO => reviewDTO.Date, opt => opt.MapFrom(review => review.Date))
            .ForMember(reviewDTO => reviewDTO.UserId, opt => opt.MapFrom(review => review.UserId))
            .ForMember(reviewDTO => reviewDTO.FullName, opt => opt.MapFrom(review => GetFullName(review.User!)));
    }

    private string GetFullName(User user)
    {
        return $"{user.Surname} {user.Name} {user.Patronymic}";
    }
}