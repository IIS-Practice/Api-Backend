using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;
public sealed class CaseRepository : ICaseRepository
{
    private readonly DbSet<Case> _cases;
    private readonly ApplicationDbContext _context;

    public CaseRepository(ApplicationDbContext context)
    {
        _context = context;
        _cases = context.Cases;
    }

    public async Task<Guid> AddCaseAsync(Case @case, CancellationToken token)
    {
        await _cases.AddAsync(@case, token);

        await _context.SaveChangesAsync(token);

        return @case.Id;
    }

    public async Task AddImageAsync(Case @case, string image, CancellationToken token)
    {
        _cases.Attach(@case);

        @case.ImagesUri.Add(image);

        await _context.SaveChangesAsync(token);
    }

    public async Task DeleteCaseAsync(Case @case, CancellationToken token)
    {
        _cases.Remove(@case);

        await _context.SaveChangesAsync(token);
    }

    public Task<Case?> FirstOrDefaultCaseAsync(Expression<Func<Case, bool>> filtres, CancellationToken token, params Expression<Func<Case, object>>[]? includesProperties)
    {
        IQueryable<Case> query = _cases.AsNoTracking().AsQueryable();

        if (includesProperties is not null
                && includesProperties.Length != 0) 
        {
            foreach (var include in  includesProperties)
            {
                query = query.Include(include);
            }
        }

        return query.FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<Case>> GetCasesAsync(Expression<Func<Case, bool>>? filtres, CancellationToken token, params Expression<Func<Case, object>>[]? includesProperties)
    {
        IQueryable<Case> query = _cases.AsNoTracking().AsQueryable();

        if (includesProperties is not null
                && includesProperties.Length != 0)
        {
            foreach (var include in includesProperties)
            {
                query = query.Include(include);
            }
        }

        if (filtres is null)
        {
            return Task.FromResult(query.AsEnumerable());
        }

        return Task.FromResult(query.Where(filtres).AsEnumerable());
    }

    public async Task RemoveImageAsync(Case @case, string image, CancellationToken token)
    {
        _cases.Attach(@case);

        @case.ImagesUri.Remove(image);

        await _context.SaveChangesAsync(token);
    }

    public async Task<Guid> UpdateCaseAsync(Case @case, CancellationToken token)
    {
        _cases.Update(@case);

        await _context.SaveChangesAsync(token);

        return @case.Id;
    }
}
