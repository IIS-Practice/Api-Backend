using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


using IIS.API.Application.Services.FaqService;


namespace IIS.API.Presentation.Controllers;


[Route("api/[controller]")]
[ApiController]
public sealed class FaqsController : ControllerBase
{
    private readonly IFaqService _service;

    public FaqsController(IFaqService service)
    {
        _service = service;
    }

    // GET: api/<FaqsController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Faq> response = await _service.GetAllAsync(token);

        return Ok(response);
    }

    // GET api/<FaqsController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            Faq? response = await _service.GetFirstOrDefault(f => f.Id == faqId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    // POST api/<FaqsController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Faq faq, CancellationToken token)
    {
        await _service.AddAsync(faq, token);

        return Ok();
    }

    // PUT api/<FaqsController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Faq faq, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            faq.Id = faqId;
            await _service.UpdateAsync(faq, token);

            return Ok();
        }

        return NotFound();
    }

    // DELETE api/<FaqsController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var faqId))
        {
            await _service.DeleteAsync(faqId, token);

            return Ok();
        }

        return NotFound();
    }
}
