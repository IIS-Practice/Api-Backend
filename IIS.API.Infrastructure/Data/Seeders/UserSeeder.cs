using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class UserSeeder
{
    public static void SeedUsers(this EntityTypeBuilder<User> userConfBuilder)
    {
        userConfBuilder.HasData([
            new User() {
                Id = Guid.NewGuid(),
                Name = "Name 1",
                Surname = "Surname 1",
                Patronymic = "Patronymic 1",
                PhoneNumber = "+375 (29) 111-11-11",
                Email = "email1@gmail.com",
                NormalizedEmail = "email1@gmail.com",
                City = "City 1",
                Country = "Country 1",
                Password = "Qq12345678qQ",
                DateOfBirth =DateTime.Now.AddYears(-20), //DateOnly.FromDateTime(DateTime.Now.AddYears(-20)),
                Gender = 1
        },
        new User() {
                Id = Guid.NewGuid(),
                Name = "Name 2",
                Surname = "Surname 2",
                Patronymic = "Patronymic 2",
                PhoneNumber = "+375 (29) 222-22-22",
                Email = "email2@gmail.com",
                NormalizedEmail = "email2@gmail.com",
                City = "City 2",
                Country = "Country 2",
                Password = "Qq12345678qQ",
                DateOfBirth = DateTime.Now.AddYears(-50), //DateOnly.FromDateTime(DateTime.Now.AddYears(-50)),
                Gender = 2
        },
        ]);
    }
}
