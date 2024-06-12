using IIS.API.Application.Services.FaqService;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace IIS.API.Presentation.Controllers;


[Route("api/[controller]")]
[ApiController]
public sealed class FaqsController : ControllerBase
{
    private readonly IFaqService _faqService;

    public FaqsController(IFaqService service)
    {
        _faqService = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Faq> response = await _faqService.GetFaqsAsync(token);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            Faq? response = await _faqService.FirstOrDefaultFaqAsync(f => f.Id == faqId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Faq faq, CancellationToken token)
    {
        await _faqService.AddFaqAsync(faq, token);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] Faq faq, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            faq.Id = faqId;
            await _faqService.UpdateFaqAsync(faq, token);

            return Ok();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            await _faqService.DeleteFaqAsync(faqId, token);

            return Ok();
        }

        return NotFound();
    }
}
