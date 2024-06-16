using IIS.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Application.Services.ApplicationService;
public interface IApplicationService
{
    public Task<Guid> AddApplicationAsync(DomainApplication application, CancellationToken token);

    public Task<Guid> UpdateApplicationAsync(DomainApplication application, CancellationToken token);

    public Task DeleteApplicationAsync(Guid applicationId, CancellationToken token);

    public Task<IEnumerable<DomainApplication>> GetApplicationsAsync(CancellationToken token);

    public Task<DomainApplication?> GetFirstOrDefaultApplicationAsync(Expression<Func<DomainApplication, bool>> predicate, CancellationToken token);
}
