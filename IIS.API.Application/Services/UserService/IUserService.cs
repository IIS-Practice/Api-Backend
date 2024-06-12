using IIS.API.Domain.Entities;
using System.Linq.Expressions;

namespace IIS.API.Application.Services.UserService;
public interface IUserService
{
    public Task<Guid> AddAsync(User user, CancellationToken token);

    public Task<Guid> UpdateAsync(User user, CancellationToken token);

    public Task DeleteAsync(Guid userId, CancellationToken token);

    public Task<IEnumerable<User>> GetAllAsync(CancellationToken token);

    public Task<User?> GetFirstOrDefault(Expression<Func<User, bool>> predicate, CancellationToken token);
}