using FluentValidation;
using IIS.API.Domain.Entities;

namespace IIS.API.Application.Services.CaseService;
public class CreateCaseValidator : AbstractValidator<Case>
{
    public CreateCaseValidator()
    {
        RuleFor(c => c.Name).NotNull()
            .NotEmpty().WithMessage("Name cannot be empty")
            .MaximumLength(30).WithMessage("Name length must be at least 30");

        RuleFor(c => c.Description).NotNull()
            .NotEmpty().WithMessage("Description cannot be empty");

        RuleFor(c => c.Cost).NotNull()
           .GreaterThan(0).WithMessage("Cost must be greater than zero")
           .PrecisionScale(10, 2, true).WithMessage("Cost must have up to 2 decimal places");

        RuleFor(c => c.Complexity).NotNull()
            .InclusiveBetween(0, 10).WithMessage("Complexity must be between 0 and 10");

        RuleFor(c => c.StartDate).NotNull()
            .NotEmpty().WithMessage("Start date cannot be empty")
            .LessThanOrEqualTo(DateTime.Now).WithMessage($"Start date must be less or equal to {DateTime.Now.Date}");

        RuleFor(c => c.EndDate).NotNull()
            .NotEmpty().WithMessage("Start date cannot be empty")
            .GreaterThan(c => c.StartDate).WithMessage($"End date must be greater than start date");

    }
}
