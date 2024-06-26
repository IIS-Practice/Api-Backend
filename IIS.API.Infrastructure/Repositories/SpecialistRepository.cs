﻿using IIS.API.Domain.Abstractions;
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace IIS.API.Infrastructure.Repositories;
public sealed class SpecialistRepository : ISpecialistRepository
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<Specialist> _specialists;

    public SpecialistRepository(ApplicationDbContext context)
    {
        _context = context;
        _specialists = context.Specialists;
    }

    public async Task AddServiceToSpecialistAsync(Specialist specialist, Service service, CancellationToken token)
    {
        _specialists.Attach(specialist);

        specialist.Services.Add(service);

        await _context.SaveChangesAsync(token);
    }

    public async Task<Guid> AddSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        specialist.Id = Guid.NewGuid();
        specialist.NormalizedEmail = specialist.Email.ToLower();

        await _specialists.AddAsync(specialist, token);
        await _context.SaveChangesAsync(token);

        return specialist.Id;
    }

    public async Task DeleteSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        _specialists.Remove(specialist);
        await _context.SaveChangesAsync(token);
    }

    public Task<Specialist?> FirstOrDefaultSpecialistAsync(Expression<Func<Specialist, bool>> filtres, 
                                                                CancellationToken token, 
                                                                params Expression<Func<Specialist, object>>[]? includesProperties)
    {
        IQueryable<Specialist> query = _specialists.AsNoTracking().AsQueryable();

        if (includesProperties is not null && includesProperties.Length != 0)
        {
            foreach (var property in includesProperties)
            {
                query = query.Include(property);
            }
        }

        return query.FirstOrDefaultAsync(filtres, token);
    }

    public Task<IEnumerable<Specialist>> GetSpecialistsAsync(Expression<Func<Specialist, bool>>? filtres, 
                                                                CancellationToken token, 
                                                                params Expression<Func<Specialist, object>>[]? includesProperties)
    {
        IQueryable<Specialist> query = _specialists.AsNoTracking().AsQueryable();

        if (includesProperties is not null && includesProperties.Length != 0)
        {
            foreach (var property in includesProperties)
            {
                query = query.Include(property);
            }
        }

        if (filtres is null)
            return Task.FromResult(query.AsEnumerable());

        return Task.FromResult(query.Where(filtres).AsEnumerable());
    }

    public async Task RemoveCvAsync(Specialist specialist, CancellationToken token)
    {
        _specialists.Attach(specialist);

        specialist.CvUri = null;

        await _context.SaveChangesAsync(token);
    }

    public async Task RemoveImageAsync(Specialist specialist, CancellationToken token)
    {
        _specialists.Attach(specialist);

        specialist.ImageUri = null;

        await _context.SaveChangesAsync(token);
    }

    public async Task SaveCvAsync(Specialist specialist, string cvUri, CancellationToken token)
    {
        _specialists.Attach(specialist);

        specialist.CvUri = cvUri;

        await _context.SaveChangesAsync(token);
    }

    public async Task SaveImageAsync(Specialist specialist, string image, CancellationToken token)
    {
        _specialists.Attach(specialist);

        specialist.ImageUri = image;

        await _context.SaveChangesAsync(token);
    }

    public async Task<Guid> UpdateSpecialistAsync(Specialist specialist, CancellationToken token)
    {
        specialist.NormalizedEmail = specialist.Email.ToLower();

        _specialists.Update(specialist);
        await _context.SaveChangesAsync(token);

        return specialist.Id;
    }
}
