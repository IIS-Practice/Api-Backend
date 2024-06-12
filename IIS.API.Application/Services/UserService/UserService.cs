using FluentValidation;
using FluentValidation.Results;
using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.UserService;
public sealed class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly AbstractValidator<User> _validator;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
        _validator = new CreateUserValidator();
    }

    public async Task<Guid> AddAsync(User user, CancellationToken token)
    {
        ValidationResult valRes = _validator.Validate(user);

        if (!valRes.IsValid)
        {
            throw new ValidationException(valRes.Errors);
        }

        await _repository.AddUserAsync(user, token);

        return user.Id;
    }

    public async Task DeleteAsync(Guid userId, CancellationToken token)
    {
        User? user = await _repository.FirstOrDefaultAsync(u => u.Id == userId, token);

        if (user == default)
            throw new KeyNotFoundException("User not found");

        await _repository.DeleteUserAsync(user, token);
    }

    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token)
    {
        return await _repository.GetAllUsersAsync(null, token);
    }

    public async Task<User?> GetFirstOrDefault(Expression<Func<User, bool>> predicate, CancellationToken token)
    {
        return await _repository.FirstOrDefaultAsync(predicate, token);
    }

    public async Task<Guid> UpdateAsync(User user, CancellationToken token)
    {
        User? dbUser = await _repository.FirstOrDefaultAsync(u => u.Id == user.Id, token);

        if (user == default)
            throw new KeyNotFoundException("User not found");

        ValidationResult valRes = _validator.Validate(user);

        if (!valRes.IsValid)
        {
            throw new ValidationException(valRes.Errors);
        }

        return await _repository.UpdateUserAsync(user, token);
    }
}
