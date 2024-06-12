using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;

public interface IReviewRepository
{
    Task<Guid> AddReviewAsync(Review review, CancellationToken token);

    Task<IEnumerable<Review>> GetReviewsAsync(Expression<Func<Review, bool>>? filters, CancellationToken token);

    Task<Guid> UpdateReviewAsync(Review review, CancellationToken token);

    Task DeleteReviewAsync(Review review, CancellationToken token);

    Task<Review?> FirstOrDefaultReviewAsync(Expression<Func<Review, bool>> filters, CancellationToken token);
}
