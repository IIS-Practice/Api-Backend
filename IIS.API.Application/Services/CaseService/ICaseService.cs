using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.CaseService;
public interface ICaseService
{
    public Task<Guid> AddCaseAsync(Case @case, CancellationToken token);

    public Task<Guid> UpdateCaseAsync(Case @case, CancellationToken token);

    public Task DeleteCaseAsync(Guid @caseId, CancellationToken token);

    public Task<IEnumerable<Case>> GetCasesAsync(CancellationToken token);

    public Task<Case?> GetFirstOrDefaultCaseAsync(Expression<Func<Case, bool>> predicate, CancellationToken token);

    public Task AddReviewToCaseAsync(Guid @caseId, Guid reviewId, CancellationToken token);

    public Task AddImageAsync(Guid caseId, IFormFile image, CancellationToken token);
}
