using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class ServiceEntityTypeConfigurator : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> serviceConfigBuilder)
    {
        serviceConfigBuilder.ToTable("Serveces");

        serviceConfigBuilder.HasKey(s => s.Id);

        serviceConfigBuilder.Property(s => s.Name).IsRequired().HasMaxLength(30);
        serviceConfigBuilder.Property(s => s.Description).IsRequired();
        serviceConfigBuilder.Property(s => s.Cost).IsRequired().HasPrecision(10, 2);
        serviceConfigBuilder.Property(s => s.Complexity).IsRequired();

        serviceConfigBuilder.HasMany(s => s.Specialists)
           .WithMany(s => s.Services)
           .UsingEntity<Dictionary<string, object>>(
               "ServiceSpecialists",
               s => s.HasOne<Specialist>().WithMany().HasForeignKey("SpecialistId"),
               s => s.HasOne<Service>().WithMany().HasForeignKey("ServiceId"));

        serviceConfigBuilder.HasMany(s => s.Cases)
            .WithMany(c => c.Services)
            .UsingEntity<Dictionary<string, object>>(
                "ServiceCases",
                s => s.HasOne<Case>().WithMany().HasForeignKey("CaseId"),
                s => s.HasOne<Service>().WithMany().HasForeignKey("ServiceId"));

        serviceConfigBuilder.SeedServices();
    }
}
