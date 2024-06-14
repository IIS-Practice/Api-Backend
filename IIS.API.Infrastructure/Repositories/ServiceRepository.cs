using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IIS.API.Infrastructure.Repositories;
internal class ServiceRepository : IServiceRepository
{
    private readonly DbSet<Service> _serviceServices;
    private readonly ApplicationDbContext _context;
    public ServiceRepository(ApplicationDbContext context)
    {
        _context = context;
        _serviceServices = context.Services;
    }
    public async Task<Guid> AddServiceAsync(Service service, CancellationToken token)
    {
        service.Id = Guid.NewGuid();

        await _serviceServices.AddAsync(service, token);
        await _context.SaveChangesAsync(token);

        return service.Id;
    }

    public async Task DeleteServiceAsync(Service service, CancellationToken token)
    {
        _serviceServices.Remove(service);
        await _context.SaveChangesAsync(token);
    }

    public async Task<Service?> FirstOrDefaultServiceAsync(Expression<Func<Service, bool>> filtres, CancellationToken token)
    {
        return await _serviceServices.AsNoTracking().FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<Service>> GetAllServicesAsync(Expression<Func<Service, bool>>? filtres, CancellationToken token)
    {
        if (filtres is null)
            return Task.FromResult(_serviceServices.AsNoTracking().AsEnumerable());

        return Task.FromResult(_serviceServices.AsNoTracking().Where(filtres).AsEnumerable());
    }

    public async Task<Guid> UpdateServiceAsync(Service service, CancellationToken token)
    {
        _serviceServices.Update(service);
        await _context.SaveChangesAsync(token);

        return service.Id;
    }
}
