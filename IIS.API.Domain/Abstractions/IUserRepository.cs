using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Domain.Abstractions;

public interface IUserRepository
{
    public Task<Guid> AddUserAsync(User user, CancellationToken token);

    public Task<IEnumerable<User>> GetUsersAsync(Expression<Func<User, bool>>? filtres, CancellationToken token);

    public Task<Guid> UpdateUserAsync(User user, CancellationToken token);

    public Task DeleteUserAsync(User user, CancellationToken token);

    public Task<User?> FirstOrDefaultUserAsync(Expression<Func<User, bool>> filtres, CancellationToken token);
}
