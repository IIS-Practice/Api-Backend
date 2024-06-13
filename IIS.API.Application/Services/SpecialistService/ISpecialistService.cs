using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.SpecialistService;
public interface ISpecialistService
{
    public Task<Guid> AddSpecialistAsync(Specialist specialist, CancellationToken token);

    public Task<Guid> UpdateSpecialistAsync(Specialist specialist, CancellationToken token);

    public Task DeleteSpecialistAsync(Guid specialistId, CancellationToken token);

    public Task<IEnumerable<Specialist>> GetSpecialistsAsync(CancellationToken token);

    public Task<Specialist?> GetFirstOrDefaultSpecialistAsync(Expression<Func<Specialist, bool>> predicate, CancellationToken token);
}
