using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Application.Services.ServiceService;
internal class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;
    private readonly AbstractValidator<Service> _serviceValidator;
    public ServiceService(IServiceRepository repository)
    {
        _serviceRepository = repository;
        _serviceValidator = new CreateServiceValidator();
    }
    public async Task<Guid> AddServiceAsync(Service service, CancellationToken token)
    {
        ValidationResult valirateRes = await _serviceValidator.ValidateAsync(service, token);

        if (!valirateRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valirateRes.Errors);
        }

        await _serviceRepository.AddServiceAsync(service, token);

        return service.Id;
    }

    public async Task DeleteServiceAsync(Guid ServiceId, CancellationToken token)
    {
        Service? service = await _serviceRepository.FirstOrDefaultServiceAsync(s => s.Id == ServiceId, token);

        if (service == default)
            throw new KeyNotFoundException("Service not found");

        await _serviceRepository.DeleteServiceAsync(service, token);
    }

    public Task<IEnumerable<Service>> GetServicesAsync(CancellationToken token)
    {
        return _serviceRepository.GetAllServicesAsync(null, token);
    }

    public async Task<Service?> GetFirstOrDefaultServiceAsync(Expression<Func<Service, bool>> predicate, CancellationToken token)
    {
        return await _serviceRepository.FirstOrDefaultServiceAsync(predicate, token);
    }

    public async Task<Guid> UpdateServiceAsync(Service service, CancellationToken token)
    {
        Service? existService = await _serviceRepository.FirstOrDefaultServiceAsync(s => s.Id == service.Id, token);
        ValidationResult valirateRes = await _serviceValidator.ValidateAsync(service, token);

        if (existService == default)
            throw new KeyNotFoundException("Service not found");

        if (!valirateRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valirateRes.Errors);
        }

        return await _serviceRepository.UpdateServiceAsync(service, token);
    }
}
