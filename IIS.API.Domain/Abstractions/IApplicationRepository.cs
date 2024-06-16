using IIS.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Domain.Abstractions;
public interface IApplicationRepository
{
    public Task<Guid> AddApplicationAsync(Application application, CancellationToken token);

    public Task<IEnumerable<Application>> GetApplicationsAsync(Expression<Func<Application, bool>>? filtres, CancellationToken token);

    public Task<Guid> UpdateApplicationAsync(Application application, CancellationToken token);

    public Task DeleteApplicationAsync(Application application, CancellationToken token);

    public Task<Application?> FirstOrDefaultApplicationAsync(Expression<Func<Application, bool>> filtres, CancellationToken token);
}
