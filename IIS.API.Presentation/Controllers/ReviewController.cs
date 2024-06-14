using AutoMapper;
using IIS.API.Application.Services.ReviewService;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Review;
using Microsoft.AspNetCore.Mvc;

namespace IIS.API.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class ReviewsController : ControllerBase
{
    private readonly IReviewService _reviewService;
    private readonly IMapper _mapper;

    public ReviewsController(IReviewService service, IMapper mapper)
    {
        _reviewService = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Review> response = await _reviewService.GetReviewsAsync(token);

        var reviewDTOs = _mapper.Map<IEnumerable<ReviewDTO>>(response);
        return Ok(reviewDTOs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            var response = await _reviewService.GetFirstOrDefaultReviewAsync(r => r.Id == reviewId, token);

            if (response is null)
            {
                return NotFound();
            }
            
            var reviewDTO = _mapper.Map<ReviewDTO>(response);

            return Ok(reviewDTO);
        }
        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ReviewRequestDTO reviewRequestDTO, CancellationToken token)
    {
        var review = _mapper.Map<Review>(reviewRequestDTO);

        await _reviewService.AddReviewAsync(review, token);
        
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] ReviewRequestDTO reviewRequestDTO, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            var review = _mapper.Map<Review>(reviewRequestDTO);
            review.Id = reviewId;
            
            await _reviewService.UpdateReviewAsync(review, token);
            
            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var reviewId))
        {
            await _reviewService.DeleteReviewAsync(reviewId, token);

            return NoContent();
        }
        return NotFound();
    }
}

