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

using DomainApplication = Domain.Entities.Application;
internal class ApplicationEntityTypeConfigurator : IEntityTypeConfiguration<DomainApplication>
{
    public void Configure(EntityTypeBuilder<DomainApplication> applicationConfigBuilder)
    {
        applicationConfigBuilder.ToTable("Applications");

        applicationConfigBuilder.HasKey(a => a.Id);

        applicationConfigBuilder.Property(a => a.Author).IsRequired().HasMaxLength(20);
        applicationConfigBuilder.Property(a => a.Description).IsRequired();
        applicationConfigBuilder.Property(u => u.PhoneNumber).IsRequired();
        applicationConfigBuilder.Property(u => u.Email).IsRequired().HasMaxLength(30);
        applicationConfigBuilder.Property(u => u.NormalizedEmail).IsRequired();
        applicationConfigBuilder.Property(u => u.Date).IsRequired().HasDefaultValue(DateTime.UtcNow);

        applicationConfigBuilder.SeedApplications();
    }
}
