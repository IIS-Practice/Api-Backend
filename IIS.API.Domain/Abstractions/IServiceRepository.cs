using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;
public interface IServiceRepository
{
    public Task<Guid> AddServiceAsync(Service service, CancellationToken token);

    public Task<IEnumerable<Service>> GetAllServicesAsync(Expression<Func<Service, bool>>? filtres, CancellationToken token, params Expression<Func<Service, object>>[]? includesProperties);

    public Task<Guid> UpdateServiceAsync(Service service, CancellationToken token);

    public Task DeleteServiceAsync(Service service, CancellationToken token);

    public Task<Service?> FirstOrDefaultServiceAsync(Expression<Func<Service, bool>> filtres, CancellationToken token, params Expression<Func<Service, object>>[]? includesProperties);

    public Task AddCaseToServiceAsync(Service service, Case @case, CancellationToken token);
}
