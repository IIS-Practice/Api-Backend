using FluentValidation;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Application.Services.ApplicationService;
internal class CreateApplicationValidator : AbstractValidator<DomainApplication>
{
    public CreateApplicationValidator()
    {
        RuleFor(u => u.Author).NotNull()
            .NotEmpty().WithMessage("Author cannot be empty")
            .MaximumLength(20).WithMessage("Author length must be at least 20");

        RuleFor(u => u.Description).NotNull()
            .NotEmpty().WithMessage("Description cannot be empty");

        RuleFor(u => u.Email).NotNull()
            .EmailAddress().WithMessage("Email must contain @")
            .MaximumLength(20).WithMessage("Email length must be at least 30"); ;

        //RuleFor(u => u.Date).NotNull();

        RuleFor(u => u.PhoneNumber).NotNull()
            .Matches(@"^\+375\s\((29|33|25|44)\)\s\d{3}-\d{2}-\d{2}$").WithMessage("The phone number does not match the pattern. Example: +375 (29/33/25/44) 111-11-11");
    }
}
