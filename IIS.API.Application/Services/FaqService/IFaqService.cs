using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.FaqService;
public interface IFaqService
{
    public Task<Guid> AddFaqAsync(Faq faq, CancellationToken token);

    public Task<Guid> UpdateFaqAsync(Faq faq, CancellationToken token);

    public Task DeleteFaqAsync(Guid FaqId, CancellationToken token);

    public Task<IEnumerable<Faq>> GetFaqsAsync(CancellationToken token);

    public Task<Faq?> FirstOrDefaultFaqAsync(Expression<Func<Faq, bool>> predicate, CancellationToken token);
}
