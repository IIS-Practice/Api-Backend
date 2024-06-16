using AutoMapper;
using IIS.API.Application.Services.ServiceService;
using IIS.API.Domain.Entities;
using IIS.API.Presentation.Common.Models.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace IIS.API.Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServicesController : ControllerBase
{
    private readonly IServiceService _serviceService;
    private readonly IMapper _mapper;
    public ServicesController(IServiceService serviceService, IMapper mapper)
    {
        _serviceService = serviceService;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ServiceDTO>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<Service> data = await _serviceService.GetServicesAsync(token);

        IEnumerable<ServiceDTO> response = _mapper.Map<IEnumerable<ServiceDTO>>(data);

        return Ok(response);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ServiceDTO), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var serviceId))
        {
            Service? response = await _serviceService.GetFirstOrDefaultServiceAsync(s => s.Id == serviceId, token);

            return response is null ? NotFound() : Ok(_mapper.Map<ServiceDTO>(response));
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ServiceRequestDTO serviceDTO, CancellationToken token)
    {
        Service service = _mapper.Map<Service>(serviceDTO);

        await _serviceService.AddServiceAsync(service, token);

        return NoContent();
    }

    [HttpPost("{serviceId}")]
    public async Task<IActionResult> PostCase([FromRoute] string serviceId, [FromBody] string caseId, CancellationToken token)
    {
        if (Guid.TryParse(serviceId, out Guid servId)
                && Guid.TryParse(caseId, out Guid casId))
        {
            await _serviceService.AddCaseToServiceAsync(servId, casId, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] ServiceRequestDTO serviceDTO, CancellationToken token)
    {
        Service service = _mapper.Map<Service>(serviceDTO);

        if (Guid.TryParse(id, out var serviceId))
        {
            service.Id = serviceId;
            await _serviceService.UpdateServiceAsync(service, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var serviceId))
        {
            await _serviceService.DeleteServiceAsync(serviceId, token);

            return NoContent();
        }

        return NotFound();
    }
}
