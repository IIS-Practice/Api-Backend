﻿using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Infrastructure;
public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Faq> Faqs => Set<Faq>();

    public DbSet<User> Users => Set<User>();

    public DbSet<Service> Services => Set<Service>();

    public DbSet<Review> Reviews => Set<Review>();

    public DbSet<Specialist> Specialists => Set<Specialist>();

    public DbSet<DomainApplication> Applications => Set<DomainApplication>();

    public DbSet<Case> Cases => Set<Case>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FaqEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new UserEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ServiceEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new CaseEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ReviewEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ApplicationEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new SpecialistEntityTypeConfigurator());

        base.OnModelCreating(modelBuilder);
    }
}
