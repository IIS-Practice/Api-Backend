using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.ServiceService;
public interface IServiceService
{
    public Task<Guid> AddServiceAsync(Service service, CancellationToken token);

    public Task<Guid> UpdateServiceAsync(Service service, CancellationToken token);

    public Task DeleteServiceAsync(Guid ServiceId, CancellationToken token);

    public Task<IEnumerable<Service>> GetServicesAsync(CancellationToken token);

    public Task<Service?> GetFirstOrDefaultServiceAsync(Expression<Func<Service, bool>> predicate, CancellationToken token);

    public Task AddCaseToServiceAsync(Guid serviceId, Guid caseId, CancellationToken token);
}
