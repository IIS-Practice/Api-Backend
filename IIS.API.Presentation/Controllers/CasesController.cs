using AutoMapper;
using IIS.API.Application.Services.CaseService;
using IIS.API.Application.Services.ReviewService;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Case;
using IIS.API.Presentation.Common.Models.Review;
using Microsoft.AspNetCore.Mvc;

namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CasesController : ControllerBase
{
    private readonly ICaseService _caseService;
    private readonly IMapper _mapper;

    public CasesController(ICaseService service, IMapper mapper)
    {
        _caseService = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Case> response = await _caseService.GetCasesAsync(token);

        var caseDTOs = _mapper.Map<IEnumerable<CaseDTO>>(response);
        return Ok(caseDTOs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var caseId))
        {
            var response = await _caseService.GetFirstOrDefaultCaseAsync(c => c.Id == caseId, token);

            if (response is null)
            {
                return NotFound();
            }

            var caseDTO = _mapper.Map<CaseDTO>(response);

            return Ok(caseDTO);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CaseRequestDTO caseRequestDTO, CancellationToken token)
    {
        var review = _mapper.Map<Case>(caseRequestDTO);

        await _caseService.AddCaseAsync(review, token);

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] CaseRequestDTO caseRequestDTO, CancellationToken token)
    {
        if (Guid.TryParse(id, out var caseId))
        {
            var @case = _mapper.Map<Case>(caseRequestDTO);
            @case.Id = caseId;

            await _caseService.UpdateCaseAsync(@case, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var caseId))
        {
            await _caseService.DeleteCaseAsync(caseId, token);

            return NoContent();
        }
        return NotFound();
    }
}
