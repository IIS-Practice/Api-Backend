using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class FaqSeeder
{
    public static void SeedFaqs(this EntityTypeBuilder<Faq> faqConfBuilder)
    {
        faqConfBuilder.HasData([
            new Faq {
                Id = Guid.Parse("68ef8340-f170-46de-ac5f-5a7f59f2103e"),
                Question = "Question 1",
                Answer = "Answer 1"
            },
            new Faq {
                Id = Guid.Parse("68ef8259-f170-46de-ac5f-5a7f59f2103e"),
                Question = "Question 2",
                Answer = "Answer 2"
            },
            new Faq {
                Id = Guid.Parse("68ef8340-f170-79de-ac5f-5a7f53f2103e"),
                Question = "Question 3",
                Answer = "Answer 3"
            },
            ]);
    }
}
