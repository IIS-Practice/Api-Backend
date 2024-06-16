using IIS.API.Application.Services.ApplicationService;
using IIS.API.Application.Services.UserService;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

using DomainApplication = IIS.API.Domain.Entities.Application;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
    // GET: api/<ApplicationsController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<DomainApplication> response = await _applicationService.GetApplicationsAsync(token);

        return Ok(response);
    }

    // GET api/<ApplicationsController>/5
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

    // POST api/<ApplicationsController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] DomainApplication application, CancellationToken token)
    {
        await _applicationService.AddApplicationAsync(application, token);

        return Ok();
    }

    // PUT api/<ApplicationsController>/5
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

    // DELETE api/<ApplicationsController>/5
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
