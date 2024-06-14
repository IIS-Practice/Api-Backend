using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;
public sealed class UserRepository : IUserRepository
{
    private readonly DbSet<User> _users;
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _users = context.Users;
        _context = context;
    }

    public async Task<Guid> AddUserAsync(User user, CancellationToken token)
    {
        user.Id = Guid.NewGuid();
        user.NormalizedEmail = user.Email.ToLower();

        await _users.AddAsync(user, token);
        await _context.SaveChangesAsync(token);

        return user.Id;
    }

    public async Task DeleteUserAsync(User user, CancellationToken token)
    {
        _users.Remove(user);
        await _context.SaveChangesAsync(token);
    }

    public Task<User?> FirstOrDefaultUserAsync(Expression<Func<User, bool>> filtres, CancellationToken token)
    {
        return _users.AsNoTracking().FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<User>> GetUsersAsync(Expression<Func<User, bool>>? filtres, CancellationToken token)
    {
        if (filtres is null)
            return Task.FromResult(_users.AsNoTracking().AsEnumerable());

        return Task.FromResult(_users.AsNoTracking().Where(filtres).AsEnumerable());
    }

    public async Task<Guid> UpdateUserAsync(User user, CancellationToken token)
    {
        user.NormalizedEmail = user.Email.ToLower();

        _users.Update(user);
        await _context.SaveChangesAsync(token);

        return user.Id;
    }
}
