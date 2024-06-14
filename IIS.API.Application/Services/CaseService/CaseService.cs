using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.CaseService;
internal sealed class CaseService : ICaseService
{
    private readonly ICaseRepository _caseRepository;
    private readonly IReviewRepository _reviewRepository;

    private readonly AbstractValidator<Case> _caseValidator;

    public CaseService(ICaseRepository caseRepository, IReviewRepository reviewRepository)
    {
        _caseRepository = caseRepository;
        _reviewRepository = reviewRepository;
        _caseValidator = new CreateCaseValidator();
    }

    public Task<Guid> AddCaseAsync(Case @case, CancellationToken token)
    {
        ValidationResult valRes = _caseValidator.Validate(@case);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return _caseRepository.AddCaseAsync(@case, token);
    }

    public async Task AddReviewToCaseAsync(Guid caseId, Guid reviewId, CancellationToken token)
    {
        Case? @case = await _caseRepository.FirstOrDefaultCaseAsync(c => c.Id == caseId, token);

        if (@case == default)
        {
            throw new KeyNotFoundException("Case not found");
        }

        Review? review = await _reviewRepository.FirstOrDefaultReviewAsync(r => r.Id == reviewId, token);

        if (review == default)
        {
            throw new KeyNotFoundException("Review not found");
        }

        await _caseRepository.AddReviewToCaseAsync(@case, review, token);
    }

    public async Task DeleteCaseAsync(Guid caseId, CancellationToken token)
    {
        Case? @case = await _caseRepository.FirstOrDefaultCaseAsync(c => c.Id == caseId, token);

        if (@case == default)
        {
            throw new KeyNotFoundException("Case not found");
        }

        await _caseRepository.DeleteCaseAsync(@case, token);
    }

    public Task<IEnumerable<Case>> GetCasesAsync(CancellationToken token)
    {
        return _caseRepository.GetCasesAsync(null, token, c => c.Rewiews, c => c.Services);
    }

    public Task<Case?> GetFirstOrDefaultCaseAsync(Expression<Func<Case, bool>> predicate, CancellationToken token)
    {
        return _caseRepository.FirstOrDefaultCaseAsync(predicate, token, c => c.Rewiews, c => c.Services);
    }

    public Task<Guid> UpdateCaseAsync(Case @case, CancellationToken token)
    {
        ValidationResult valRes = _caseValidator.Validate(@case);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return _caseRepository.UpdateCaseAsync(@case, token);
    }
}
