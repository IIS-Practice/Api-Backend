using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;
public interface ICaseRepository
{
    public Task<Guid> AddCaseAsync(Case @case, CancellationToken token);

    public Task<IEnumerable<Case>> GetCasesAsync(Expression<Func<Case, bool>>? filtres, CancellationToken token, params Expression<Func<Case, object>>[]? includesProperties);

    public Task<Guid> UpdateCaseAsync(Case @case, CancellationToken token);

    public Task DeleteCaseAsync(Case @case, CancellationToken token);

    public Task<Case?> FirstOrDefaultCaseAsync(Expression<Func<Case, bool>> filtres, CancellationToken token, params Expression<Func<Case, object>>[]? includesProperties);

    public Task AddImageAsync(Case @case, string image, CancellationToken token);

    public Task RemoveImageAsync(Case @case, string image, CancellationToken token);
}
