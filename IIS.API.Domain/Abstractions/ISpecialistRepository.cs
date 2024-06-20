using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;
public interface ISpecialistRepository
{
    public Task<Guid> AddSpecialistAsync(Specialist specialist, CancellationToken token);

    public Task<IEnumerable<Specialist>> GetSpecialistsAsync(Expression<Func<Specialist, bool>>? filtres, CancellationToken token, params Expression<Func<Specialist, object>>[]? includesProperties);

    public Task<Guid> UpdateSpecialistAsync(Specialist specialist, CancellationToken token);

    public Task DeleteSpecialistAsync(Specialist specialist, CancellationToken token);

    public Task<Specialist?> FirstOrDefaultSpecialistAsync(Expression<Func<Specialist, bool>> filtres, CancellationToken token, params Expression<Func<Specialist, object>>[]? includesProperties);

    public Task AddServiceToSpecialistAsync(Specialist specialist, Service service, CancellationToken token);

    public Task SaveCvAsync(Specialist specialist, string cvUri,  CancellationToken token);

    public Task RemoveCvAsync(Specialist specialist, CancellationToken token);

    public Task SaveImageAsync(Specialist specialist, string image, CancellationToken token);

    public Task RemoveImageAsync(Specialist specialist, CancellationToken token);
}
