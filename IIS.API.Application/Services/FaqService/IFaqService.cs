using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.FaqService;
public interface IFaqService
{
    public Task<Guid> AddAsync(Faq faq, CancellationToken token);

    public Task<Guid> UpdateAsync(Faq faq, CancellationToken token);

    public Task DeleteAsync(Guid FaqId, CancellationToken token);

    public Task<IEnumerable<Faq>> GetAllAsync(CancellationToken token);

    public Task<Faq?> GetFirstOrDefault(Expression<Func<Faq, bool>> predicate, CancellationToken token);
}
