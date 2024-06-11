using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.FaqService;
internal sealed class FaqService : IFaqService
{
    private readonly IFaqRepository _repository;
    private readonly AbstractValidator<Faq> _validator;

    public FaqService(IFaqRepository repository)
    {
        _repository = repository;
        _validator = new CreateFaqValidator();
    }

    public async Task<Guid> AddAsync(Faq faq, CancellationToken token)
    {
        ValidationResult valirateRes = await _validator.ValidateAsync(faq, token);

        if (!valirateRes.IsValid)
        {
            throw new ValidationException(valirateRes.Errors);
        }

        await _repository.AddFaqAsync(faq, token);

        return faq.Id;
    }

    public async Task DeleteAsync(Guid faqId, CancellationToken token)
    {
        Faq? faq = await _repository.FirstOrDefaultAsync(f => f.Id == faqId, token);

        if (faq == default)
            throw new KeyNotFoundException("Faq not found");

        await _repository.DeleteAsync(faq, token);
    }

    public Task<IEnumerable<Faq>> GetAllAsync(CancellationToken token)
    {
        return _repository.GetAllFaqsAsync(null, token);
    }

    public async Task<Faq?> GetFirstOrDefault(Expression<Func<Faq, bool>> predicate, CancellationToken token)
    {
        return await _repository.FirstOrDefaultAsync(predicate, token);
    }

    public async Task<Guid> UpdateAsync(Faq faq, CancellationToken token)
    {
        Faq? existFaq = await _repository.FirstOrDefaultAsync(f => f.Id == faq.Id, token);

        if (existFaq == default)
            throw new KeyNotFoundException("Faq not found");

        return await _repository.UpdateAsync(faq, token);
    }
}
