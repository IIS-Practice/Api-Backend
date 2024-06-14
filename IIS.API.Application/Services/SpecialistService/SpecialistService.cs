using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.SpecialistService;
internal sealed class SpecialistService : ISpecialistService
{
    private readonly ISpecialistRepository _specialistRepository;
    private readonly IServiceRepository _serviceRepository;
    private readonly AbstractValidator<Specialist> _specialistValidator;

    public SpecialistService(ISpecialistRepository specialistRepository, IServiceRepository serviceRepository)
    {
        _specialistRepository = specialistRepository;
        _serviceRepository = serviceRepository;
        _specialistValidator = new CreateSpecialistValidator();
    }

    public async Task<Guid> AddSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        ValidationResult valRes = _specialistValidator.Validate(specialist);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return await _specialistRepository.AddSpecialistAsync(specialist, token);
    }

    public async Task DeleteSpecialistAsync(Guid specialistId, CancellationToken token)
    {
        Specialist? specialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialistId, token);

        if (specialist == default)
            throw new KeyNotFoundException("Specialist not found");

        await _specialistRepository.DeleteSpecialistAsync(specialist, token);
    }

    public Task<Specialist?> GetFirstOrDefaultSpecialistAsync(Expression<Func<Specialist, bool>> predicate, CancellationToken token)
    {
        return _specialistRepository.FirstOrDefaultSpecialistAsync(predicate, token);
    }

    public Task<IEnumerable<Specialist>> GetSpecialistsAsync(CancellationToken token)
    {
        return _specialistRepository.GetSpecialistsAsync(null, token, s => s.Services);
    }

    public async Task<Guid> UpdateSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        Specialist? dbSpecialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialist.Id, token);

        if (dbSpecialist == default)
            throw new KeyNotFoundException("Specialist not found");

        ValidationResult valRes = _specialistValidator.Validate(specialist);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return await _specialistRepository.UpdateSpecialistAsync(specialist, token);
    }

    public async Task AddServiceToSpecialistAsync(Guid specialistId, Guid serviceId, CancellationToken token)
    {
        Specialist? specialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialistId, token);

        if (specialist == default)
            throw new KeyNotFoundException("Specialist not found");

        Service? service = await _serviceRepository.FirstOrDefaultServiceAsync(s => s.Id == serviceId, token);

        if (service == default)
            throw new KeyNotFoundException("Service not found");

        await _specialistRepository.AddServiceToSpecialistAsync(specialist, service, token);
    }
}
