using FluentValidation;
using IIS.API.Domain.Entities;

namespace IIS.API.Application.Services.ServiceService;
internal class CreateServiceValidator : AbstractValidator<Service>
{
    public CreateServiceValidator()
    {
        RuleFor(u => u.Name).NotNull()
            .NotEmpty().WithMessage("Name cannot be empty")
            .MaximumLength(30).WithMessage("Name length must be at least 30");

        RuleFor(s => s.Description).NotNull()
            .NotEmpty().WithMessage("Description cannot be empty");

        RuleFor(s => s.Cost).NotNull()
            .GreaterThan(0).WithMessage("Cost must be greater than zero")
            .PrecisionScale(10, 2, true).WithMessage("Cost must have up to 2 decimal places");

        RuleFor(s => s.Complexity).NotNull()
            .InclusiveBetween(0, 10).WithMessage("Complexity must be between 0 and 10");
    }
}