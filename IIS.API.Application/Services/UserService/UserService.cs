using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.UserService;
public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly AbstractValidator<User> _userValidator;

    public UserService(IUserRepository repository)
    {
        _userRepository = repository;
        _userValidator = new CreateUserValidator();
    }

    public async Task<Guid> AddUserAsync(User user, CancellationToken token)
    {
        ValidationResult valRes = _userValidator.Validate(user);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        await _userRepository.AddUserAsync(user, token);

        return user.Id;
    }

    public async Task DeleteUserAsync(Guid userId, CancellationToken token)
    {
        User? user = await _userRepository.FirstOrDefaultUserAsync(u => u.Id == userId, token);

        if (user == default)
            throw new KeyNotFoundException("User not found");

        await _userRepository.DeleteUserAsync(user, token);
    }

    public async Task<IEnumerable<User>> GetUsersAsync(CancellationToken token)
    {
        return await _userRepository.GetUsersAsync(null, token);
    }

    public async Task<User?> GetFirstOrDefaultUserAsync(Expression<Func<User, bool>> predicate, CancellationToken token)
    {
        return await _userRepository.FirstOrDefaultUserAsync(predicate, token);
    }

    public async Task<Guid> UpdateUserAsync(User user, CancellationToken token)
    {
        User? dbUser = await _userRepository.FirstOrDefaultUserAsync(u => u.Id == user.Id, token);

        if (user == default)
            throw new KeyNotFoundException("User not found");

        ValidationResult valRes = _userValidator.Validate(user);

        if (!valRes.IsValid)
        {
            throw new Common.Exceptions.ValidationException(valRes.Errors);
        }

        return await _userRepository.UpdateUserAsync(user, token);
    }
}
