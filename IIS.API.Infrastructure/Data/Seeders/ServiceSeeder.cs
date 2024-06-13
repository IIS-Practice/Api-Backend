using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class ServiceSeeder
{
    public static void SeedServices(this EntityTypeBuilder<Service> serviceConfBuilder)
    {
        serviceConfBuilder.HasData([
            new Service()
            {
                Id = Guid.NewGuid(),
                Name = "service 1",
                Description = "description 1",
                Cost = 159m,
                Complexity = 5,
                Specialists = new List<Specialist>(),
                Cases = new List<Case>()
            },
            new Service()
            {
                Id = Guid.NewGuid(),
                Name = "service 2",
                Description = "description 2",
                Cost = 109m,
                Complexity = 3,
                Specialists = new List<Specialist>(),
                Cases = new List<Case>()
            }
           ] );


    }
}
