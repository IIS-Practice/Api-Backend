using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class ServiceEntityTypeConfigurator : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> serviceConfigBuilder)
    {
        serviceConfigBuilder.ToTable(nameof(Service));

        serviceConfigBuilder.HasKey(s => s.Id);

        serviceConfigBuilder.Property(s => s.Name).IsRequired().HasMaxLength(30);
        serviceConfigBuilder.Property(s => s.Description).IsRequired();
        serviceConfigBuilder.Property(s => s.Cost).IsRequired();
        serviceConfigBuilder.Property(s => s.Complexity).IsRequired();

        serviceConfigBuilder.HasMany(s => s.Specialists)
           .WithMany(s => s.Services)
           .UsingEntity<Dictionary<string, object>>(
               "ServiceSpecialist",
               s => s.HasOne<Specialist>().WithMany().HasForeignKey("SpecialistId"),
               s => s.HasOne<Service>().WithMany().HasForeignKey("ServiceId"));

        serviceConfigBuilder.HasMany(s => s.Cases)
            .WithMany(c => c.Services)
            .UsingEntity<Dictionary<string, object>>(
                "ServiceCase",
                s => s.HasOne<Case>().WithMany().HasForeignKey("CaseId"),
                s => s.HasOne<Service>().WithMany().HasForeignKey("ServiceId"));

        serviceConfigBuilder.SeedServices();
    }
}
