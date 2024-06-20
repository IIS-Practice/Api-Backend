using AutoMapper;
using IIS.API.Application.Services.SpecialistService;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Review;
using IIS.API.Presentation.Common.Models.Specialist;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
    [ProducesResponseType(typeof(IEnumerable<SpecialistDTO>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Specialist> response = await _specialistService.GetSpecialistsAsync(token);

        return Ok(_mapper.Map<IEnumerable<SpecialistDTO>>(response));
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(SpecialistDTO), (int)HttpStatusCode.OK)]
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
    public async Task<IActionResult> Post([FromBody] SpecialistRequestDTO specialistDTO, CancellationToken token)
    {
        Specialist specialist = _mapper.Map<Specialist>(specialistDTO);

        await _specialistService.AddSpecialistAsync(specialist, token);

        return NoContent();
    }

    [HttpPost("{specialistId}")]
    public async Task<IActionResult> PostService([FromRoute] string specialistId, [FromBody] string serviceId, CancellationToken token)
    {
        if (Guid.TryParse(serviceId, out Guid servId) 
                && Guid.TryParse(specialistId, out Guid specId))
        {
            await _specialistService.AddServiceToSpecialistAsync(specId, servId, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpPost("cv/{specialistId}")]
    public async Task<IActionResult> PostService([FromRoute] string specialistId, IFormFile cv, CancellationToken token)
    {
        if (Guid.TryParse(specialistId, out Guid id) 
                && cv is not null)
        {
            await _specialistService.SaveCvAsync(id, cv, token);

            return NoContent();
        }

        return NotFound("Invaid specialist id or cv is null");
    }

    [HttpPost("avatar/{specialistId}")]
    public async Task<IActionResult> PostImageService([FromRoute] string specialistId, IFormFile image, CancellationToken token)
    {
        if (Guid.TryParse(specialistId, out Guid id)
                && image is not null)
        {
            await _specialistService.SaveImageAsync(id, image, token);

            return NoContent();
        }

        return NotFound("Invaid specialist id or image is null");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] SpecialistRequestDTO specialistDTO, CancellationToken token)
    {
        Specialist specialist = _mapper.Map<Specialist>(specialistDTO);

        if (Guid.TryParse(id, out var specialistId))
        {
            specialist.Id = specialistId;
            await _specialistService.UpdateSpecialistAsync(specialist, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var specialistId))
        {
            await _specialistService.DeleteSpecialistAsync(specialistId, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("cv/{specialistId}")]
    public async Task<IActionResult> DeleteCv([FromRoute] string specialistId, CancellationToken token)
    {
        if (Guid.TryParse(specialistId, out Guid id))
        {
            await _specialistService.RemoveCvAsync(id, token);

            return NoContent();
        }

        return NotFound("Invalid specialist Id");
    }

    [HttpDelete("avatar/{specialistId}")]
    public async Task<IActionResult> DeleteAvatar([FromRoute] string specialistId, CancellationToken token)
    {
        if (Guid.TryParse(specialistId, out Guid id))
        {
            await _specialistService.RemoveImageAsync(id, token);

            return NoContent();
        }

        return NotFound("Invalid specialist Id");
    }
}
