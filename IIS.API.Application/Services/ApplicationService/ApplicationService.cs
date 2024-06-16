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

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Application.Services.ApplicationService;
internal class ApplicationService : IApplicationService
{
    private readonly IApplicationRepository _applicationRepository;
    private readonly AbstractValidator<DomainApplication> _applicationValidator;

    public ApplicationService(IApplicationRepository repository)
    {
        _applicationRepository = repository;
        _applicationValidator = new CreateApplicationValidator();
    }
    public async Task<Guid> AddApplicationAsync(DomainApplication application, CancellationToken token)
    {
        ValidationResult valRes = _applicationValidator.Validate(application);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        await _applicationRepository.AddApplicationAsync(application, token);

        return application.Id;
    }

    public async Task DeleteApplicationAsync(Guid applicationId, CancellationToken token)
    {
        DomainApplication? application = await _applicationRepository.FirstOrDefaultApplicationAsync(a => a.Id == applicationId, token);

        if (application == default)
            throw new KeyNotFoundException("User not found");

        await _applicationRepository.DeleteApplicationAsync(application, token);
    }

    public async Task<IEnumerable<DomainApplication>> GetApplicationsAsync(CancellationToken token)
    {
        return await _applicationRepository.GetApplicationsAsync(null, token);
    }

    public async Task<DomainApplication?> GetFirstOrDefaultApplicationAsync(Expression<Func<DomainApplication, bool>> predicate, CancellationToken token)
    {
        return await _applicationRepository.FirstOrDefaultApplicationAsync(predicate, token);
    }

    public async Task<Guid> UpdateApplicationAsync(DomainApplication application, CancellationToken token)
    {
        DomainApplication? dbApplication = await _applicationRepository.FirstOrDefaultApplicationAsync(a => a.Id == application.Id, token);

        if (application == default)
            throw new KeyNotFoundException("User not found");

        ValidationResult valRes = _applicationValidator.Validate(application);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return await _applicationRepository.UpdateApplicationAsync(application, token);
    }
}
