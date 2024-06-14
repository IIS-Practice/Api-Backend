using IIS.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Domain.Abstractions;
public interface IServiceRepository
{
    public Task<Guid> AddServiceAsync(Service service, CancellationToken token);

    public Task<IEnumerable<Service>> GetAllServicesAsync(Expression<Func<Service, bool>>? filtres, CancellationToken token);

    public Task<Guid> UpdateServiceAsync(Service service, CancellationToken token);

    public Task DeleteServiceAsync(Service service, CancellationToken token);

    public Task<Service?> FirstOrDefaultServiceAsync(Expression<Func<Service, bool>> filtres, CancellationToken token);
}
