
using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;

public class ReviewEntityTypeConfigurator : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> reviewConfigBuilder)
    {
        reviewConfigBuilder.ToTable("Reviews");
    }
}
