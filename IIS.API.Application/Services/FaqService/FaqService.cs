using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.FaqService;
internal sealed class FaqService : IFaqService
{
    private readonly IFaqRepository _faqRepository;
    private readonly AbstractValidator<Faq> _faqValidator;

    public FaqService(IFaqRepository repository)
    {
        _faqRepository = repository;
        _faqValidator = new CreateFaqValidator();
    }

    public async Task<Guid> AddFaqAsync(Faq faq, CancellationToken token)
    {
        ValidationResult valirateRes = await _faqValidator.ValidateAsync(faq, token);

        if (!valirateRes.IsValid)
        {
            throw new ValidationException(valirateRes.Errors);
        }

        await _faqRepository.AddFaqAsync(faq, token);

        return faq.Id;
    }

    public async Task DeleteFaqAsync(Guid faqId, CancellationToken token)
    {
        Faq? faq = await _faqRepository.FirstOrDefaultFaqAsync(f => f.Id == faqId, token);

        if (faq == default)
            throw new KeyNotFoundException("Faq not found");

        await _faqRepository.DeleteFaqAsync(faq, token);
    }

    public Task<IEnumerable<Faq>> GetFaqsAsync(CancellationToken token)
    {
        return _faqRepository.GetFaqsAsync(null, token);
    }

    public async Task<Faq?> FirstOrDefaultFaqAsync(Expression<Func<Faq, bool>> predicate, CancellationToken token)
    {
        return await _faqRepository.FirstOrDefaultFaqAsync(predicate, token);
    }

    public async Task<Guid> UpdateFaqAsync(Faq faq, CancellationToken token)
    {
        Faq? existFaq = await _faqRepository.FirstOrDefaultFaqAsync(f => f.Id == faq.Id, token);

        if (existFaq == default)
            throw new KeyNotFoundException("Faq not found");

        ValidationResult valirateRes = await _faqValidator.ValidateAsync(faq, token);

        if (!valirateRes.IsValid)
        {
            throw new ValidationException(valirateRes.Errors);
        }

        return await _faqRepository.UpdateFaqAsync(faq, token);
    }
}
