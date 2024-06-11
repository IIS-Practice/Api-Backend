using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;
public sealed class FaqRepository : IFaqRepository
{
    private readonly DbSet<Faq> _faqs;
    private readonly ApplicationDbContext _context;

    public FaqRepository(ApplicationDbContext context)
    {
        _context = context;
        _faqs = context.Faqs;
    }

    public async Task<Guid> AddFaqAsync(Faq faq, CancellationToken token)
    {
        faq.Id = Guid.NewGuid();

        await _faqs.AddAsync(faq, token);
        await _context.SaveChangesAsync(token);

        return faq.Id;
    }

    public async Task DeleteAsync(Faq faq, CancellationToken token)
    {
        _faqs.Remove(faq);
        await _context.SaveChangesAsync(token);
    }

    public async Task<Faq?> FirstOrDefaultAsync(Expression<Func<Faq, bool>> filtres, CancellationToken token)
    {
        return await _faqs.FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<Faq>> GetAllFaqsAsync(Expression<Func<Faq, bool>>? filtres, CancellationToken token)
    {
        if (filtres is null)
            return Task.FromResult(_faqs.AsEnumerable());

        return Task.FromResult(_faqs.Where(filtres).AsEnumerable());
    }

    public async Task<Guid> UpdateAsync(Faq faq, CancellationToken token)
    {
        _faqs.Update(faq);
        await _context.SaveChangesAsync(token);

        return faq.Id;
    }
}
