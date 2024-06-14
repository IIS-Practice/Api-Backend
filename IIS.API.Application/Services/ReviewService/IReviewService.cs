using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.ReviewService;

public interface IReviewService
{
    Task<Guid> AddReviewAsync(Review review, CancellationToken token);

    Task<Guid> UpdateReviewAsync(Review review, CancellationToken token);

    Task DeleteReviewAsync(Guid reviewId, CancellationToken token);

    Task<IEnumerable<Review>> GetReviewsAsync(CancellationToken token);

    Task<Review?> GetFirstOrDefaultReviewAsync(Expression<Func<Review, bool>> predicate, CancellationToken token);
}
