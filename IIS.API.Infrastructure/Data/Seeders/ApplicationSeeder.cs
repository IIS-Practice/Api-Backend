using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DomainApplication = IIS.API.Domain.Entities.Application;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class ApplicationSeeder
{
    public static void SeedApplications(this EntityTypeBuilder<DomainApplication> applicationConfBuilder)
    {
        // при изменении id пользователя изменить id пользователя в ReviewSeeder
        applicationConfBuilder.HasData([
            new DomainApplication() {
                Id = Guid.Parse("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                Author = "Author 1",
                Description = "Description 1",
                PhoneNumber = "+375 (29) 111-11-11",
                Email = "email1@gmail.com",
                NormalizedEmail = "email1@gmail.com",
                Date =DateTime.Now,
        },
        new DomainApplication() {
                Id = Guid.Parse("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                Author = "Author 2",
                Description = "Description 2",
                PhoneNumber = "+375 (29) 222-22-22",
                Email = "email2@gmail.com",
                NormalizedEmail = "email2@gmail.com",
                Date =DateTime.Now,
        },
        ]);
    }
}
