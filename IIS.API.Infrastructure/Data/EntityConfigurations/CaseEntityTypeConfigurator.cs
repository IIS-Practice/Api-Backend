using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

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
    }
}
