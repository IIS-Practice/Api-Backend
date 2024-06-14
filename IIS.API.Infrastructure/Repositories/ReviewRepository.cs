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

        _users.Where(u => u.Id == review.UserId).Load();

        await _reviews.AddAsync(review, token);

        await _context.SaveChangesAsync(token);

        return review.Id;
    }

    public async Task DeleteReviewAsync(Review review, CancellationToken token)
    {
        _reviews.Remove(review);
        await _context.SaveChangesAsync(token);
    }

    public async Task<Review?> FirstOrDefaultReviewAsync(Expression<Func<Review, bool>> filters, CancellationToken token)
    {
        var review = await _reviews.AsNoTracking().FirstOrDefaultAsync(filters, token);

        if (review is not null)
        {
            review.User = _users.AsNoTracking().Where(u => u.Id == review.UserId).Single();
        }

        return review;
    }

    public Task<IEnumerable<Review>> GetReviewsAsync(Expression<Func<Review, bool>>? filters, CancellationToken token)
    {
        if (filters is null)
        {
            _users.Load();
            return Task.FromResult(_reviews.AsEnumerable());
        }

        var reviews = _reviews.Where(filters);

        // загрузка пользователей, отзывы которых соответствуют фильтру
        _users.Where(u => reviews.Any(r => r.UserId == u.Id)).Load();

        return Task.FromResult(reviews.AsEnumerable());
    }

    public async Task<Guid> UpdateReviewAsync(Review review, CancellationToken token)
    {
        _users.Where(u => u.Id == review.UserId).Load();

        _reviews.Update(review);

        await _context.SaveChangesAsync(token);

        return review.Id;
    }
}