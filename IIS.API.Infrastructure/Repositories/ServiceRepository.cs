using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;
internal class ServiceRepository : IServiceRepository
{
    private readonly DbSet<Service> _services;
    private readonly ApplicationDbContext _context;
    public ServiceRepository(ApplicationDbContext context)
    {
        _context = context;
        _services = context.Services;
    }

    public async Task AddCaseToServiceAsync(Service service, Case @case, CancellationToken token)
    {
        _services.Attach(service);

        service.Cases.Add(@case);

        await _context.SaveChangesAsync(token);
    }

    public async Task<Guid> AddServiceAsync(Service service, CancellationToken token)
    {
        service.Id = Guid.NewGuid();

        await _services.AddAsync(service, token);
        await _context.SaveChangesAsync(token);

        return service.Id;
    }

    public async Task DeleteServiceAsync(Service service, CancellationToken token)
    {
        _services.Remove(service);
        await _context.SaveChangesAsync(token);
    }

    public async Task<Service?> FirstOrDefaultServiceAsync(Expression<Func<Service, bool>> filtres, 
                                                            CancellationToken token, 
                                                            params Expression<Func<Service, object>>[]? includesProperties)
    {
        IQueryable<Service> query = _services.AsNoTracking().AsQueryable();

        if (includesProperties is not null 
                && includesProperties.Length != 0)
        {
            foreach (var include in includesProperties)
            {
                query = query.Include(include);
            }
        }

        return await query.FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<Service>> GetAllServicesAsync(Expression<Func<Service, bool>>? filtres, 
                                                            CancellationToken token, 
                                                            params Expression<Func<Service, object>>[]? includesProperties)
    {
        IQueryable<Service> query = _services.AsNoTracking().AsQueryable();

        if (includesProperties is not null
                && includesProperties.Length != 0)
        {
            foreach (var include in includesProperties)
            {
                query = query.Include(include);
            }
        }

        if (filtres is null)
            return Task.FromResult(query.AsEnumerable());

        return Task.FromResult(query.Where(filtres).AsEnumerable());
    }

    public async Task RemoveCaseFromServiceAsync(Service service, Case @case, CancellationToken token)
    {
        _services.Attach(service);

        Case? removedCase = service.Cases.FirstOrDefault(c => c.Id == @case.Id);

        if (removedCase == default)
            throw new ArgumentException("Service don't contains case", nameof(@case));

        service.Cases.Remove(removedCase);

        await _context.SaveChangesAsync(token);
    }

    public async Task<Guid> UpdateServiceAsync(Service service, CancellationToken token)
    {
        _services.Update(service);
        await _context.SaveChangesAsync(token);

        return service.Id;
    }
}
