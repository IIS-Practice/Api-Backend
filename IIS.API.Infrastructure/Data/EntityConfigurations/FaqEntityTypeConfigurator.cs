using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class FaqEntityTypeConfigurator : IEntityTypeConfiguration<Faq>
{
    public void Configure(EntityTypeBuilder<Faq> faqConfigBuilder)
    {
        faqConfigBuilder.ToTable("Faqs");

        faqConfigBuilder.HasKey(f => f.Id);

        faqConfigBuilder.Property(f => f.Question).IsRequired();
        faqConfigBuilder.Property(f => f.Answer).IsRequired();
    }
}
