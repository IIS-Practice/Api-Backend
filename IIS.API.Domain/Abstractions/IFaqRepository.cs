using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;
public interface IFaqRepository
{
    public Task<Guid> AddFaqAsync(Faq faq, CancellationToken token);

    public Task<IEnumerable<Faq>> GetFaqsAsync(Expression<Func<Faq, bool>>? filtres, CancellationToken token);

    public Task<Guid> UpdateFaqAsync(Faq faq, CancellationToken token);

    public Task DeleteFaqAsync(Faq faq, CancellationToken token);

    public Task<Faq?> FirstOrDefaultFaqAsync(Expression<Func<Faq, bool>> filtres, CancellationToken token);
}
