using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace IIS.API.Infrastructure;
public sealed class ApplicationDbContext :DbContext
{
    public DbSet<Faq> Faqs => Set<Faq>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Service> Services => Set<Service>();

    public DbSet<Specialist> Specialists => Set<Specialist>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureDeleted();   // удаляем бд со старой схемой
        Database.EnsureCreated();   // создаем бд с новой схемой
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FaqEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new UserEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new ServiceEntityTypeConfigurator());
        modelBuilder.ApplyConfiguration(new  SpecialistEntityTypeConfigurator());

        base.OnModelCreating(modelBuilder);
    }
}
