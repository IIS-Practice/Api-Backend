using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

using ValidationException = IIS.API.Application.Common.Exceptions.ValidationException;

namespace IIS.API.Application.Services.ServiceService;
internal class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;
    private readonly ICaseRepository _caseRepository;

    private readonly AbstractValidator<Service> _serviceValidator;
    public ServiceService(IServiceRepository repository, ICaseRepository caseRepository)
    {
        _serviceRepository = repository;
        _caseRepository = caseRepository;
        _serviceValidator = new CreateServiceValidator();
    }
    public async Task<Guid> AddServiceAsync(Service service, CancellationToken token)
    {
        ValidationResult validateRes = await _serviceValidator.ValidateAsync(service, token);

        if (!validateRes.IsValid)
        {
            throw new ValidationException(validateRes.Errors);
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
        return _serviceRepository.GetAllServicesAsync(null, token, s => s.Cases, s => s.Specialists);
    }

    public async Task<Service?> GetFirstOrDefaultServiceAsync(Expression<Func<Service, bool>> predicate, CancellationToken token)
    {
        return await _serviceRepository.FirstOrDefaultServiceAsync(predicate, token, s => s.Cases, s => s.Specialists);
    }

    public async Task<Guid> UpdateServiceAsync(Service service, CancellationToken token)
    {
        Service? existService = await _serviceRepository.FirstOrDefaultServiceAsync(s => s.Id == service.Id, token);

        if (existService == default)
            throw new KeyNotFoundException("Service not found");

        ValidationResult validateRes = await _serviceValidator.ValidateAsync(service, token);

        if (!validateRes.IsValid)
        {
            throw new ValidationException(validateRes.Errors);
        }

        return await _serviceRepository.UpdateServiceAsync(service, token);
    }

    public async Task AddCaseToServiceAsync(Guid serviceId, Guid caseId, CancellationToken token)
    {
        Service? service = await _serviceRepository.FirstOrDefaultServiceAsync(s => s.Id == serviceId, token, s => s.Cases);

        if (service == default)
            throw new KeyNotFoundException("Service not found");

        Case? @case = await _caseRepository.FirstOrDefaultCaseAsync(c => c.Id == caseId, token);

        if (@case == default)
            throw new KeyNotFoundException("Case mot found");

        await _serviceRepository.AddCaseToServiceAsync(service, @case, token);
    }
}
