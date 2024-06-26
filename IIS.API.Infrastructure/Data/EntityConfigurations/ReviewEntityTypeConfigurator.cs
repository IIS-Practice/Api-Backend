﻿
using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;

public class ReviewEntityTypeConfigurator : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> reviewConfigBuilder)
    {
        reviewConfigBuilder.ToTable("Reviews");

        reviewConfigBuilder.HasKey(r => r.Id);

        reviewConfigBuilder.Property(r => r.Text)
            .IsRequired()
            .HasMaxLength(1000);

        reviewConfigBuilder.Property(r => r.Date)
            .IsRequired();

        reviewConfigBuilder.Property(r => r.Username)
            .IsRequired()
            .HasMaxLength(30);

        reviewConfigBuilder.SeedReviews();
    }
}
