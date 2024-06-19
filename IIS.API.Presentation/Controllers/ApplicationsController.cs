using AutoMapper;
using IIS.API.Application.Services.ApplicationService;
using IIS.API.Presentation.Common.Models.Application;
using IIS.API.Presentation.Common.Models.Case;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using DomainApplication = IIS.API.Domain.Entities.Application;


namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ApplicationsController : ControllerBase
{
    private readonly IApplicationService _applicationService;
    private readonly IMapper _mapper;

    public ApplicationsController(IApplicationService applicationService, IMapper mapper)
    {
        _applicationService = applicationService;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ApplicationDTO>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<DomainApplication> data = await _applicationService.GetApplicationsAsync(token);

        IEnumerable<ApplicationDTO> response = _mapper.Map<IEnumerable<ApplicationDTO>>(data);

        return Ok(response);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApplicationDTO), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var applicationId))
        {
            DomainApplication? data = await _applicationService.GetFirstOrDefaultApplicationAsync(f => f.Id == applicationId, token);

            return data is null ? NotFound() : Ok(_mapper.Map<ApplicationDTO>(data));
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ApplicationRequestDTO application, CancellationToken token)
    {
        DomainApplication app = _mapper.Map<DomainApplication>(application);

        await _applicationService.AddApplicationAsync(app, token);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] ApplicationRequestDTO application, CancellationToken token)
    {
        DomainApplication app = _mapper.Map<DomainApplication>(application);

        if (Guid.TryParse(id, out var userId))
        {
            app.Id = userId;
            await _applicationService.UpdateApplicationAsync(app, token);

            return Ok();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            await _applicationService.DeleteApplicationAsync(userId, token);

            return Ok();
        }

        return NotFound();
    }
}
