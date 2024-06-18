using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;

public sealed class ReviewRepository : IReviewRepository
{
    private readonly DbSet<Review> _reviews;
    private readonly DbSet<User> _users;
    private readonly ApplicationDbContext _context;

    public ReviewRepository(ApplicationDbContext context)
    {
        _context = context;
        _reviews = context.Reviews;
        _users = context.Users;
    }

    public async Task<Guid> AddReviewAsync(Review review, CancellationToken token)
    {
        review.Id = Guid.NewGuid();
        review.Date = DateTime.UtcNow;

        await _reviews.AddAsync(review, token);

        await _context.SaveChangesAsync(token);

        return review.Id;
    }

    public async Task DeleteReviewAsync(Review review, CancellationToken token)
    {
        _reviews.Remove(review);
        await _context.SaveChangesAsync(token);
    }

    public Task<Review?> FirstOrDefaultReviewAsync(Expression<Func<Review, bool>> filters, CancellationToken token)
    {
        return _reviews.AsNoTracking().FirstOrDefaultAsync(filters, token);

    }

    public Task<IEnumerable<Review>> GetReviewsAsync(Expression<Func<Review, bool>>? filters, CancellationToken token)
    {
        if (filters is null)
        {
            return Task.FromResult(_reviews.AsEnumerable());
        }

        var reviews = _reviews.Where(filters);

        return Task.FromResult(reviews.AsEnumerable());
    }

    public async Task<Guid> UpdateReviewAsync(Review review, CancellationToken token)
    {
        review.Date = DateTime.UtcNow;

        _reviews.Update(review);

        await _context.SaveChangesAsync(token);

        return review.Id;
    }
}