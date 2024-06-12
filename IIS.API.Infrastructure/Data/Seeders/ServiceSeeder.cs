using IIS.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIS.API.Infrastructure.Data.Seeders;
public class ServiceSeeder
{
    public static void SeedDB(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
        if (!context.Services.Any())
        {
            var services = new List<Service>
            {
                    new Service
                    {
                        Id = Guid.NewGuid(),
                        Name = "mobile app",
                        Description = "bla bla bla",
                        Cost = 159m,
                        Complexity = 5,
                        Specialists = new List<Specialist>(), // Инициализация пустого списка
                        Cases = new List<Case>() // Инициализация пустого списка
                    },
                    new Service
                    {
                        Id = Guid.NewGuid(),
                        Name = "web app",
                        Description = "bla bla",
                        Cost = 109m,
                        Complexity = 3,
                        Specialists = new List<Specialist>(), // Инициализация пустого списка
                        Cases = new List<Case>() // Инициализация пустого списка
                    },

            };
            context.AddRange(services);
            context.SaveChanges();
        }
    }
}
