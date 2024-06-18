using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;

public static class ReviewSeeder
{
    public static void SeedReviews(this EntityTypeBuilder<Review> reviewConfBuilder)
    {
        reviewConfBuilder.HasData([
            new Review
            {
                Id = Guid.Parse("36F010ED-8C38-4EEB-B9EC-5FB86CCF3189"),
                Text = "This is review 1",
                Date = new DateTime(2024, 6, 14),
                Username = "Bobik"
            },
            new Review
            {
                Id = Guid.Parse("16A79D25-A4F4-4CF0-99EC-835073F0C946"),
                Text = "This is review 2",
                Date = new DateTime(2024, 6, 14),
                Username = "Vasula"
            },
            new Review
            {
                Id = Guid.Parse("03B061D4-2ACA-44C8-8489-C92390E21CD5"),
                Text = "This is review 3",
                Date = new DateTime(2024, 6, 14),
                Username = "Volodia"
            }]
        );
    }
}
