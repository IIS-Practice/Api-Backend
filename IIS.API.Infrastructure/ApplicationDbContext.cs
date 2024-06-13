using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace IIS.API.Infrastructure;
public sealed class ApplicationDbContext :DbContext
{
    public DbSet<Faq> Faqs => Set<Faq>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Service> Services => Set<Service>();


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FaqEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new UserEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ServiceEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new CaseEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ReviewEntityTypeConfigurator());

        base.OnModelCreating(modelBuilder);
    }
}
