using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.UserService;
public interface IUserService
{
    public Task<Guid> AddUserAsync(User user, CancellationToken token);

    public Task<Guid> UpdateUserAsync(User user, CancellationToken token);

    public Task DeleteUserAsync(Guid userId, CancellationToken token);

    public Task<IEnumerable<User>> GetUsersAsync(CancellationToken token);

    public Task<User?> GetFirstOrDefaultUserAsync(Expression<Func<User, bool>> predicate, CancellationToken token);
}