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

        //RuleFor(r => r.Date)
        //    .NotEmpty()
        //    .WithMessage("Review date cannot be empty.")
        //    .NotNull()
        //    .WithMessage("Review date cannot be null.")
        //    .LessThanOrEqualTo(r => DateTime.UtcNow);


        RuleFor(r => r.Username)
            .NotEmpty()
            .WithMessage("Username cannot be empty.")
            .NotNull()
            .WithMessage("Username cannot be null.")
            .MaximumLength(30)
            .WithMessage("Username must be less than 30 characters");
    }
}