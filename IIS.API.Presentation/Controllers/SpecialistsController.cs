using AutoMapper;
using IIS.API.Application.Services.SpecialistService;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SpecialistsController : ControllerBase
{
    private readonly ISpecialistService _specialistService;
    private readonly IMapper _mapper;

    public SpecialistsController(ISpecialistService service, IMapper mapper)
    {
        _specialistService = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Specialist> response = await _specialistService.GetSpecialistsAsync(token);

        return Ok(_mapper.Map<IEnumerable<SpecialistDTO>>(response));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var specialistId))
        {
            Specialist? response = await _specialistService.GetFirstOrDefaultSpecialistAsync(f => f.Id == specialistId, token);

            return response is null ? NotFound() : Ok(_mapper.Map<SpecialistDTO>(response));
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Specialist specialist, CancellationToken token)
    {
        await _specialistService.AddSpecialistAsync(specialist, token);

        return Ok();
    }

    [HttpPost("{specialistId}")]
    public async Task<IActionResult> PostService([FromRoute] string specialistId, [FromBody] string serviceId, CancellationToken token)
    {
        if (Guid.TryParse(serviceId, out Guid servId) 
            && Guid.TryParse(specialistId, out Guid specId))
        {
            await _specialistService.AddServiceToSpecialistAsync(specId, servId, token);

            return Ok();
        }

        return NotFound();
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
