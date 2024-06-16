using IIS.API.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Infrastructure.Repositories;
internal class ApplicationRepository : IApplicationRepository
{
    private readonly DbSet<DomainApplication> _applications;
    private readonly ApplicationDbContext _context;

    public ApplicationRepository(ApplicationDbContext context)
    {
        _applications = context.Applications;
        _context = context;
    }
    public async Task<Guid> AddApplicationAsync(DomainApplication application, CancellationToken token)
    {
        application.Id = Guid.NewGuid();
        application.NormalizedEmail = application.Email.ToLower();
        application.Date = DateTime.UtcNow;

        await _applications.AddAsync(application, token);
        await _context.SaveChangesAsync(token);

        return application.Id;
    }

    public async Task DeleteApplicationAsync(DomainApplication application, CancellationToken token)
    {
        _applications.Remove(application);
        await _context.SaveChangesAsync(token);
    }

    public Task<DomainApplication?> FirstOrDefaultApplicationAsync(Expression<Func<DomainApplication, bool>> filtres, CancellationToken token)
    {
        return _applications.AsNoTracking().FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<DomainApplication>> GetApplicationsAsync(Expression<Func<DomainApplication, bool>>? filtres, CancellationToken token)
    {
        if (filtres is null)
            return Task.FromResult(_applications.AsNoTracking().AsEnumerable());

        return Task.FromResult(_applications.AsNoTracking().Where(filtres).AsEnumerable());
    }

    public async Task<Guid> UpdateApplicationAsync(DomainApplication application, CancellationToken token)
    {
        application.NormalizedEmail = application.Email.ToLower();
        application.Date = DateTime.UtcNow;

        _applications.Update(application);
        await _context.SaveChangesAsync(token);

        return application.Id;
    }
}
