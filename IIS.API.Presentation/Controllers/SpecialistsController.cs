using IIS.API.Application.Services.SpecialistService;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SpecialistsController : ControllerBase
{
    private readonly ISpecialistService _specialistService;

    public SpecialistsController(ISpecialistService service)
    {
        _specialistService = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Specialist> response = await _specialistService.GetSpecialistsAsync(token);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var specialistId))
        {
            Specialist? response = await _specialistService.GetFirstOrDefaultSpecialistAsync(f => f.Id == specialistId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Specialist specialist, CancellationToken token)
    {
        await _specialistService.AddSpecialistAsync(specialist, token);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] Specialist specialist, CancellationToken token)
    {
        if (Guid.TryParse(id, out var specialistId))
        {
            specialist.Id = specialistId;
            await _specialistService.UpdateSpecialistAsync(specialist, token);

            return Ok();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var specialistId))
        {
            await _specialistService.DeleteSpecialistAsync(specialistId, token);

            return Ok();
        }

        return NotFound();
    }
}
