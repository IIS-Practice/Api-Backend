using IIS.API.Domain.Entities;
using IIS.API.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class UserEntityTypeConfigurator : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> UserConfigBuilder)
    {
        UserConfigBuilder.ToTable("Users");

        UserConfigBuilder.HasKey(u => u.Id);

        UserConfigBuilder.Property(u => u.Name).IsRequired().HasMaxLength(20);
        UserConfigBuilder.Property(u => u.Surname).IsRequired().HasMaxLength(20);
        UserConfigBuilder.Property(u => u.Patronymic).IsRequired().HasMaxLength(20);
        UserConfigBuilder.Property(u => u.PhoneNumber).IsRequired();
        UserConfigBuilder.Property(u => u.Email).IsRequired().HasMaxLength(30);
        UserConfigBuilder.Property(u => u.NormalizedEmail).IsRequired();
        UserConfigBuilder.Property(u => u.Password).IsRequired();
        UserConfigBuilder.Property(u => u.City).IsRequired().HasMaxLength(20);
        UserConfigBuilder.Property(u => u.Country).IsRequired().HasMaxLength(20);
        UserConfigBuilder.Property(u => u.DateOfBirth).IsRequired();
        UserConfigBuilder.Property(u => u.Gender).IsRequired();

        UserConfigBuilder.HasIndex(u => new { u.NormalizedEmail, u.Password }).IsUnique();

        UserConfigBuilder.SeedUsers();
    }
}
