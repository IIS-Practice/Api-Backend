using FluentValidation;
using FluentValidation.Results;
using IIS.API.Application.Common.Options;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using Microsoft.Extensions.Options;

using ValidationException = IIS.API.Application.Common.Exceptions.ValidationException;

namespace IIS.API.Application.Services.CaseService;
internal sealed class CaseService : ICaseService
{
    private readonly ICaseRepository _caseRepository;
    private readonly IReviewRepository _reviewRepository;

    private readonly AbstractValidator<Case> _caseValidator;

    private readonly WWWRootOptions _options;
    private readonly string _imageFolder = string.Empty;

    public CaseService(ICaseRepository caseRepository, IReviewRepository reviewRepository, IOptions<WWWRootOptions> options)
    {
        _caseRepository = caseRepository;
        _reviewRepository = reviewRepository;

        _options = options.Value;
        _imageFolder = Path.Combine(_options.WebRootPath, "Images/Cases");

        _caseValidator = new CreateCaseValidator();
    }

    public async Task<Guid> AddCaseAsync(Case @case, CancellationToken token)
    {
        ValidationResult valRes = _caseValidator.Validate(@case);

        if (!valRes.IsValid)
        {
            throw new ValidationException(valRes.Errors);
        }

        Guid id = await _caseRepository.AddCaseAsync(@case, token);

        Directory.CreateDirectory(Path.Combine(_imageFolder, id.ToString()));

        return id;
    }

    public async Task AddImageAsync(Guid caseId, IFormFile image, CancellationToken token)
    {
        Case? @case = await _caseRepository.FirstOrDefaultCaseAsync(c => c.Id == caseId, token);

        if (@case == default)
        {
            throw new KeyNotFoundException("Case not found");
        }

        string extension = Path.GetExtension(image.FileName);
        string fileName = Path.ChangeExtension(Path.GetRandomFileName(), extension);

        string filePath = Path.Combine(_imageFolder, @case.Id.ToString(), fileName);

        using Stream fileStream = new FileStream(filePath, FileMode.Create);
        await image.CopyToAsync(fileStream, token);

        await _caseRepository.AddImageAsync(@case, Path.Combine($"{_options.Host}/Images/Cases", @case.Id.ToString(), fileName), token);
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

        string caseImages = Path.Combine(_imageFolder, @case.Id.ToString());

        if (Directory.Exists(caseImages))
            Directory.Delete(caseImages);
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
            throw new ValidationException(valRes.Errors);
        }

        return _caseRepository.UpdateCaseAsync(@case, token);
    }
}
