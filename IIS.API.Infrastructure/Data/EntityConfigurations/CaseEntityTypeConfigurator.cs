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

        caseConfigBuilder.HasKey(s => s.Id);

        caseConfigBuilder.Property(s => s.Name).IsRequired().HasMaxLength(30);
        caseConfigBuilder.Property(s => s.Description).IsRequired();
        caseConfigBuilder.Property(s => s.Cost).IsRequired().HasPrecision(10, 2);
        caseConfigBuilder.Property(s => s.Complexity).IsRequired();

        caseConfigBuilder.SeedCases();
    }
}
