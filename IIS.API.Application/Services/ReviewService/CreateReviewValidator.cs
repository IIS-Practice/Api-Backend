using FluentValidation;
using IIS.API.Domain.Entities;

namespace IIS.API.Application.Services.ReviewService;
internal class CreateReviewValidator : AbstractValidator<Review>
{
    public CreateReviewValidator()
    {
        RuleFor(r => r.Text)
            .NotEmpty()
            .WithMessage("Review text cannot be empty.")
            .NotNull()
            .WithMessage("Review text cannot be null.");

        RuleFor(r => r.Date)
            .NotEmpty()
            .WithMessage("Review date cannot be empty.")
            .NotNull()
            .WithMessage("Review date cannot be null.")
            .LessThanOrEqualTo(r => DateTime.UtcNow);


        RuleFor(r => r.UserId)
            .NotEmpty()
            .WithMessage("User ID cannot be empty.")
            .NotNull()
            .WithMessage("User ID cannot be null.");
    }
}