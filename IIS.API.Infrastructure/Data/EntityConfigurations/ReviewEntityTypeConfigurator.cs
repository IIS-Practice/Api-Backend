using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;

public class ReviewEntityTypeConfigurator : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> reviewConfigBuilder)
    {
        reviewConfigBuilder.ToTable(nameof(Review));

        reviewConfigBuilder.HasKey(r => r.Id);

        reviewConfigBuilder.Property(r => r.Text)
            .IsRequired()
            .HasMaxLength(1000);

        reviewConfigBuilder.Property(r => r.Date)
            .IsRequired();

        reviewConfigBuilder.Property(r => r.UserId)
            .IsRequired();

        reviewConfigBuilder.HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Restrict); 
    }
}
