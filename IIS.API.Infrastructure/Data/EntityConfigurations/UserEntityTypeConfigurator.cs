using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.EntityConfigurations;
internal class UserEntityTypeConfigurator : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> UserConfigBuilder)
    {
        UserConfigBuilder.ToTable(nameof(User));

        UserConfigBuilder.HasKey(u => u.Id);

        UserConfigBuilder.Property(u => u.Name).IsRequired();
        UserConfigBuilder.Property(u => u.Surname).IsRequired();
        UserConfigBuilder.Property(u => u.Patronymic).IsRequired();
        UserConfigBuilder.Property(u => u.Email).IsRequired();
        UserConfigBuilder.Property(u => u.NormalizedEmail).IsRequired();
        UserConfigBuilder.Property(u => u.Password).IsRequired();
        UserConfigBuilder.Property(u => u.City).IsRequired();
        UserConfigBuilder.Property(u => u.Country).IsRequired();
        UserConfigBuilder.Property(u => u.DateOfBirth).IsRequired();
        UserConfigBuilder.Property(u => u.Gender).IsRequired();
    }
}
