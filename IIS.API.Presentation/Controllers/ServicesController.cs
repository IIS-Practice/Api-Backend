
using IIS.API.Application.Services.FaqService;
using IIS.API.Application.Services.ServiceService;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServicesController : ControllerBase
{
    private readonly IServiceService _serviceService;
    public ServicesController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    // GET: api/<ServicesController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Service> response = await _serviceService.GetServicesAsync(token);

        return Ok(response);
    }

    // GET api/<ServicesController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var serviceId))
        {
            Service? response = await _serviceService.GetFirstOrDefaultServiceAsync(s => s.Id == serviceId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    // POST api/<ServicesController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Service service, CancellationToken token)
    {
        await _serviceService.AddServiceAsync(service, token);

        return Ok();
    }

    // PUT api/<ServicesController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] Service service, CancellationToken token)
    {
        if (Guid.TryParse(id, out var serviceId))
        {
            service.Id = serviceId;
            await _serviceService.UpdateServiceAsync(service, token);

            return Ok();
        }

        return NotFound();
    }

    // DELETE api/<ServicesController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var serviceId))
        {
            await _serviceService.DeleteServiceAsync(serviceId, token);

            return Ok();
        }

        return NotFound();
    }
}
