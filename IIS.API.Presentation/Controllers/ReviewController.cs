using Microsoft.AspNetCore.Mvc;
using IIS.API.Application.Services.ReviewService;
using IIS.API.Domain.Entities;

namespace IIS.API.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class ReviewsController : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewsController(IReviewService service)
    {
        _reviewService = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Review> response = await _reviewService.GetReviewsAsync(token);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            Review? response = await _reviewService.GetFirstOrDefaultReviewAsync(r => r.Id == reviewId, token);
            return response is null ? NotFound() : Ok(response);
        }
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Review review, CancellationToken token)
    {
        await _reviewService.AddReviewAsync(review, token);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] Review review, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            review.Id = reviewId;
            await _reviewService.UpdateReviewAsync(review, token);
            return Ok();
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            await _reviewService.DeleteReviewAsync(reviewId, token);
            return Ok();
        }
        return NotFound();
    }
}

