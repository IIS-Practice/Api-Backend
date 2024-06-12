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

        await _users.AddAsync(user, token);
        await _context.SaveChangesAsync(token);

        return user.Id;
    }

    public async Task DeleteUserAsync(User user, CancellationToken token)
    {
        _users.Remove(user);
        await _context.SaveChangesAsync(token);
    }

    public Task<User?> FirstOrDefaultAsync(Expression<Func<User, bool>> filtres, CancellationToken token)
    {
        return _users.FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<User>> GetAllUsersAsync(Expression<Func<User, bool>>? filtres, CancellationToken token)
    {
        if (filtres is null)
            return Task.FromResult(_users.AsEnumerable());

        return Task.FromResult(_users.Where(filtres).AsEnumerable());
    }

    public async Task<Guid> UpdateUserAsync(User user, CancellationToken token)
    {
        _users.Update(user);
        await _context.SaveChangesAsync(token);

        return user.Id;
    }
}
