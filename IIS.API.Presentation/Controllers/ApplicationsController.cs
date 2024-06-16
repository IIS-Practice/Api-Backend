using IIS.API.Application.Services.ApplicationService;
using Microsoft.AspNetCore.Mvc;

using DomainApplication = IIS.API.Domain.Entities.Application;


namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ApplicationsController : ControllerBase
{
    private readonly IApplicationService _applicationService;

    public ApplicationsController(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<DomainApplication> response = await _applicationService.GetApplicationsAsync(token);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var applicationId))
        {
            DomainApplication? response = await _applicationService.GetFirstOrDefaultApplicationAsync(f => f.Id == applicationId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] DomainApplication application, CancellationToken token)
    {
        await _applicationService.AddApplicationAsync(application, token);

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] DomainApplication application, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            application.Id = userId;
            await _applicationService.UpdateApplicationAsync(application, token);

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
