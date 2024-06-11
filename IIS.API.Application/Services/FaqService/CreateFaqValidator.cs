using FluentValidation;
using IIS.API.Domain.Entities;

namespace IIS.API.Application.Services.FaqService;
internal class CreateFaqValidator : AbstractValidator<Faq>
{
    public CreateFaqValidator()
    {
        RuleFor(f => f.Question).NotEmpty().NotNull();
        RuleFor(f => f.Answer).NotEmpty().NotNull();
    }
}
