using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class CaseSeeder
{
    public static void SeedCases(this EntityTypeBuilder<Case> caseConfBuilder)
    {
        caseConfBuilder.HasData([
            new Case
            {
                Id = Guid.Parse("36F010ED-8C38-4EEB-B9EC-5FB56CCF3189"),
                Name = "Name 1",
                Description = "Description 1",
                Complexity = 5,
                Cost = 1400,
                StartDate = DateTime.Now.AddMonths(-5),
                EndDate = DateTime.Now,
            },
            new Case
            {
                Id = Guid.Parse("36F056ED-8C38-4EEB-B9EC-5FB56CCF3189"),
                Name = "Name 2",
                Description = "Description 2",
                Complexity = 8,
                Cost = 3500,
                StartDate = DateTime.Now.AddYears(-1),
                EndDate = DateTime.Now.AddMonths(-2),
            },
            new Case
            {
                Id = Guid.Parse("15F010ED-8C38-4EEB-B9EC-5FB36CCF3189"),
                Name = "Name 3",
                Description = "Description 3",
                Complexity = 2,
                Cost = 500,
                StartDate = DateTime.Now.AddMonths(-1),
                EndDate = DateTime.Now,
            },
            ]);
    }
}
