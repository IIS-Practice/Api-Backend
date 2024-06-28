using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class CaseEntityTypeConfigurator : IEntityTypeConfiguration<Case>
{
    public void Configure(EntityTypeBuilder<Case> caseConfigBuilder)
    {
        caseConfigBuilder.ToTable("Cases");

        caseConfigBuilder.HasKey(c => c.Id);

        caseConfigBuilder.Property(c => c.Name).IsRequired().HasMaxLength(30);
        caseConfigBuilder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);
        caseConfigBuilder.Property(c => c.Description).IsRequired();
        caseConfigBuilder.Property(c => c.Cost).IsRequired().HasPrecision(10, 2);
        caseConfigBuilder.Property(c => c.Complexity).IsRequired();

        caseConfigBuilder.SeedCases();
    }
}
