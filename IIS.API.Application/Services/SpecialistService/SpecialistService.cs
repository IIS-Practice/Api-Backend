using FluentValidation;
using FluentValidation.Results;
using IIS.API.Application.Common.Options;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;

using ValidationException = IIS.API.Application.Common.Exceptions.ValidationException;

namespace IIS.API.Application.Services.SpecialistService;
internal sealed class SpecialistService : ISpecialistService
{
    private readonly ISpecialistRepository _specialistRepository;
    private readonly IServiceRepository _serviceRepository;

    private readonly AbstractValidator<Specialist> _specialistValidator;

    private readonly WWWRootOptions _options;
    private readonly string _specialistFolder;

    public SpecialistService(ISpecialistRepository specialistRepository, 
                                IServiceRepository serviceRepository,
                                IOptions<WWWRootOptions> options)
    {
        _specialistRepository = specialistRepository;
        _serviceRepository = serviceRepository;

        _specialistValidator = new CreateSpecialistValidator();

        _options = options.Value;
        _specialistFolder = Path.Combine(_options.WebRootPath, "Images/Specialists");
    }

    public async Task<Guid> AddSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        ValidationResult valRes = _specialistValidator.Validate(specialist);

        if (!valRes.IsValid)
        {
            throw new ValidationException(valRes.Errors);
        }

        return await _specialistRepository.AddSpecialistAsync(specialist, token);
    }

    public async Task DeleteSpecialistAsync(Guid specialistId, CancellationToken token)
    {
        Specialist? specialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialistId, token);

        if (specialist == default)
            throw new KeyNotFoundException("Specialist not found");

        if (specialist.ImageUri is not null)
        {
            string? file = Directory.EnumerateFiles(Path.Combine(_options.WebRootPath, "cv"))
                                .Where(f => specialist.ImageUri.Contains(f)).FirstOrDefault();

            if (file == default)
                throw new KeyNotFoundException("Deleted image not found");

            File.Delete(file);
        }

        await _specialistRepository.DeleteSpecialistAsync(specialist, token);
    }

    public Task<Specialist?> GetFirstOrDefaultSpecialistAsync(Expression<Func<Specialist, bool>> predicate, CancellationToken token)
    {
        return _specialistRepository.FirstOrDefaultSpecialistAsync(predicate, token, s => s.Services);
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
            throw new ValidationException(valRes.Errors);
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

    public async Task SaveCvAsync(Guid specialistId, IFormFile cvFile, CancellationToken token)
    {
        Specialist? specialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialistId, token);

        if (specialist == default)
            throw new KeyNotFoundException("Specialist not found");

        if (specialist.CvUri is not null)
        {
            string? file = Directory.EnumerateFiles(Path.Combine(_options.WebRootPath, "cv"))
                                .Where(f => specialist.CvUri.Contains(f)).FirstOrDefault();

            if (file == default)
                throw new KeyNotFoundException("Deleted cv not found");

            File.Delete(file);
        }

        string filePath = GetFilePath(cvFile.FileName, Path.Combine(_options.WebRootPath, "Images/Specialists/cv"), out string fName);

        using Stream fileStream = new FileStream(filePath, FileMode.Create);
        await cvFile.CopyToAsync(fileStream, token);

        await _specialistRepository.SaveCvAsync(specialist, Path.Combine($"{_options.Host}/Images/Specialists/cv", fName), token);
    }

    public async Task SaveImageAsync(Guid specialistId, IFormFile imageFile, CancellationToken token)
    {
        Specialist? specialist = await _specialistRepository.FirstOrDefaultSpecialistAsync(s => s.Id == specialistId, token);

        if (specialist == default)
            throw new KeyNotFoundException("Specialist not found");

        if (specialist.ImageUri is not null)
        {
            string? file = Directory.EnumerateFiles(Path.Combine(_options.WebRootPath, "Avatar"))
                                .Where(f => specialist.ImageUri.Contains(f)).FirstOrDefault();

            if (file == default)
                throw new KeyNotFoundException("Deleted image not found");

            File.Delete(file);
        }

        string filePath = GetFilePath(imageFile.FileName, Path.Combine(_options.WebRootPath, "Images/Specialists/Avatar"), out string fName);

        using Stream fileStream = new FileStream(filePath, FileMode.Create);
        await imageFile.CopyToAsync(fileStream, token);

        await _specialistRepository.SaveCvAsync(specialist, Path.Combine($"{_options.Host}/Images/Specialists/Avatar", fName), token);
    }

    private static string GetFilePath(string fileName, string folderPath, out string newFileName)
    {
        string extension = Path.GetExtension(fileName);
        newFileName = Path.ChangeExtension(Path.GetRandomFileName(), extension);

        return Path.Combine(folderPath, newFileName);
    }
}
