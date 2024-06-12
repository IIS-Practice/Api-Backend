using FluentValidation;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;
using ValidationException = IIS.API.Application.Common.Exceptions.ValidationException;

namespace IIS.API.Application.Services.ReviewService;

internal sealed class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;
    private readonly AbstractValidator<Review> _validator;
    //private readonly IUserRepository _userRepository;

    public ReviewService(IReviewRepository repository)
    {
        _reviewRepository = repository;
        _validator = new CreateReviewValidator();
    }

    public async Task<Guid> AddReviewAsync(Review review, CancellationToken token)
    {
        var validateRes = await _validator.ValidateAsync(review, token);

        if (!validateRes.IsValid)
        {
            throw new ValidationException(validateRes.Errors);
        }

        await _reviewRepository.AddReviewAsync(review, token);

        return review.Id;
    }

    public async Task DeleteReviewAsync(Guid reviewId, CancellationToken token)
    {
        var review = await _reviewRepository.FirstOrDefaultReviewAsync(r => r.Id == reviewId, token);

        if (review == default)
            throw new KeyNotFoundException("Review not found");

        await _reviewRepository.DeleteReviewAsync(review, token);
    }

    public Task<IEnumerable<Review>> GetReviewsAsync(CancellationToken token)
    {
        return _reviewRepository.GetReviewsAsync(null, token);
    }

    public async Task<Review?> GetFirstOrDefaultReviewAsync(Expression<Func<Review, bool>> predicate, CancellationToken token)
    {
        return await _reviewRepository.FirstOrDefaultReviewAsync(predicate, token);
    }

    public async Task<Guid> UpdateReviewAsync(Review review, CancellationToken token)
    {
        var existReview = await _reviewRepository.FirstOrDefaultReviewAsync(r => r.Id == review.Id, token);

        if (existReview == default)
            throw new KeyNotFoundException("Review not found");

        //TODO:
        //var user = await _userRepository.FirstOrDefaultAsync(u => u.Id == review.UserId, token);

        //if (user == default)
        //    throw new KeyNotFoundException("User not found");

        await _reviewRepository.UpdateReviewAsync(review, token);

        return review.Id;
    }
}
