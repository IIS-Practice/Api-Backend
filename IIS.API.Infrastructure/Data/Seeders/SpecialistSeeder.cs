using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class SpecialistSeeder
{
    public static void SeedSpecialists(this EntityTypeBuilder<Specialist> specialistConfBuilder)
    {
        specialistConfBuilder.HasData([
            new Specialist() {
                Id = Guid.Parse("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                Name = "Name 3",
                Surname = "Surname 3",
                Patronymic = "Patronymic 3",
                PhoneNumber = "+375 (29) 333-33-33",
                Email = "email3@gmail.com",
                NormalizedEmail = "email3@gmail.com",
                City = "City 3",
                Country = "Country 3",
                Password = "Qq12345678qQ",
                DateOfBirth =DateTime.Now.AddYears(-20),
                Gender = 1,
                Position = "Position 1"
        },
        new Specialist() {
                Id = Guid.Parse("45bf8340-f203-46de-ac5f-5a7f59f2103e"),
                Name = "Name 4",
                Surname = "Surname 4",
                Patronymic = "Patronymic 4",
                PhoneNumber = "+375 (29) 444-44-44",
                Email = "email4@gmail.com",
                NormalizedEmail = "email4@gmail.com",
                City = "City 4",
                Country = "Country 4",
                Password = "Qq12345678qQ",
                DateOfBirth = DateTime.Now.AddYears(-50),
                Gender = 2,
                Position = "Position 2"
        },
        ]);
    }
}

