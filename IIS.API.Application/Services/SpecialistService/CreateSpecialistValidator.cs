using FluentValidation;
using IIS.API.Domain.Entities;

namespace IIS.API.Application.Services.SpecialistService;
public class CreateSpecialistValidator : AbstractValidator<Specialist>
{
    public CreateSpecialistValidator()
    {
        RuleFor(s => s.Name).NotNull()
            .NotEmpty().WithMessage("Name cannot be empty")
            .MaximumLength(20).WithMessage("Name length must be at least 20");

        RuleFor(s => s.Surname).NotNull()
            .NotEmpty().WithMessage("Surname cannot be empty")
            .MaximumLength(20).WithMessage("Surname length must be at least 20");

        RuleFor(s => s.Patronymic).NotNull()
            .NotEmpty().WithMessage("Patronymic cannot be empty")
            .MaximumLength(20).WithMessage("Patronymic length must be at least 20");

        RuleFor(s => s.Email).NotNull()
            .EmailAddress().WithMessage("Email must contain @")
            .MaximumLength(20).WithMessage("Email length must be at least 30"); ;

        RuleFor(s => s.City).NotNull()
            .NotEmpty().WithMessage("City cannot be empty")
            .MaximumLength(20).WithMessage("City length must be at least 20");

        RuleFor(s => s.Country).NotNull()
            .NotEmpty().WithMessage("Country cannot be empty")
            .MaximumLength(20).WithMessage("Country length must be at least 20");

        RuleFor(s => s.Password).NotEmpty().WithMessage("Password cannot be empty")
                    .MinimumLength(8).WithMessage("Password length must be at least 8.")
                    .MaximumLength(16).WithMessage("Password length must not exceed 16.")
                    .Matches(@"[A-Z]+").WithMessage("Password must contain at least one uppercase letter.")
                    .Matches(@"[a-z]+").WithMessage("Password must contain at least one lowercase letter.")
                    .Matches(@"[0-9]+").WithMessage("Password must contain at least one number.");

        RuleFor(s => s.DateOfBirth).NotNull()
            .NotEmpty().WithMessage("Date of birth cannot be empty")
            .GreaterThanOrEqualTo(DateTime.Parse("01.01.1900")).WithMessage("Date of birth must be greater than 01.01.1900")
            .LessThan(DateTime.Now).WithMessage($"Date of birth must be less than {DateTime.Now.Date}");

        RuleFor(s => s.Gender).NotNull()
            .GreaterThanOrEqualTo(0).WithMessage("Gender must be greater or equal to 0")
            .LessThan(3).WithMessage("Gender must be less than 3");

        RuleFor(s => s.PhoneNumber).NotNull()
            .Matches(@"^\+375\s\([29|33]\)\s\d{3}-\d{2}-\d{2}$").WithMessage("The phone number does not match the pattern. Example: +375 (29/33) 111-11-11");

        RuleFor(s => s.Position).NotNull()
            .NotEmpty().WithMessage("Position cannot be empty");
    }
}
