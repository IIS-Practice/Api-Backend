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
                Name = "PITA STREET FOOD",
                ShortDescription = "Разработка сайта для корректного отображения на всех устройствах!",
                Description = "   <div class=\"case-description\" style=\"margin-top: 100px;\">\r\n          <h2 style=\"font-size: 1.75rem; font-weight: 600; line-height: 2.133rem; margin-bottom: 60px;\">\r\n            PITA STREET FOOD\r\n          </h2>\r\n          <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; margin-bottom: 15px;\">\r\n            Специализируется на <br /> кулинарии\r\n          </p>\r\n        </div>\r\n        <div class=\"project-details-image\" style=\"display: flex; flex-direction: row; margin-bottom: 130px;\">\r\n          <img style=\"height: 37.3rem; width: 27.7rem; object-fit: cover; margin-right: 3%;\" src=\"https://avatars.mds.yandex.net/i?id=48a4918289cb9ad4a778c06b628dfd8765dc83a0-12146588-images-thumbs&n=13\" alt=\"Project Details\" />\r\n          <div class=\"info\" style=\"display: flex; justify-content: space-between; flex-direction: column;\">\r\n            <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; text-align: left;\">\r\n              Компания “PITA STREET FOOD” обратилась к нам за разработкой полноценного сайта их заведения. В ходе живого общения с нашими специалистами, заказчик четко определился со структурой сайта, также в ТЗ была включена реализация платёжной системы сайта.\r\n            </p>\r\n            <p style=\"font-size: 1.5rem; font-weight: 400; line-height: 1.828rem; text-align: left;\">\r\n              На ранних этапах сотрудничества, мы составили поэтапную смету, промежуточные сроки реализации, в рамках которых вели дальнейшую разработку проекта.\r\n            </p>\r\n          </div>\r\n        </div>",
                Complexity = 6,
                Cost = 900,
                StartDate = DateTime.Now.AddMonths(-5),
                EndDate = DateTime.Now,
            },
            ]);
    }
}
