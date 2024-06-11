using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;
public interface IFaqRepository
{
    public Task<Guid> AddFaqAsync(Faq faq, CancellationToken token);

    public Task<IEnumerable<Faq>> GetAllFaqsAsync(Expression<Func<Faq, bool>>? filtres, CancellationToken token);

    public Task<Guid> UpdateAsync(Faq faq, CancellationToken token);

    public Task DeleteAsync(Faq faq, CancellationToken token);

    public Task<Faq?> FirstOrDefaultAsync(Expression<Func<Faq, bool>> filtres, CancellationToken token);
}
