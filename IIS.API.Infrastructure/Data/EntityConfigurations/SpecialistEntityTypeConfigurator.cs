using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class SpecialistEntityTypeConfigurator : IEntityTypeConfiguration<Specialist>
{
    public void Configure(EntityTypeBuilder<Specialist> specialistConfigBuilder)
    {
        specialistConfigBuilder.Property(s => s.Position).IsRequired();

        specialistConfigBuilder.SeedSpecialists();
    }
}
