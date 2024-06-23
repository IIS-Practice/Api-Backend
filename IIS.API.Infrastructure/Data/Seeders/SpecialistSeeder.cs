﻿using IIS.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IIS.API.Infrastructure.Data.Seeders;
public static class SpecialistSeeder
{
    public static void SeedSpecialists(this EntityTypeBuilder<Specialist> specialistConfBuilder)
    {
        specialistConfBuilder.HasData([
            new Specialist() {
                Id = Guid.Parse("68bf8123-f170-46de-ac5f-5a7f59f2103e"),
                Name = "Киану",
                Surname = "Ривз",
                Patronymic = "Чарьзович",
                Email = "kiany@gmail.com",
                NormalizedEmail = "Kiany@gmail.com",
                PhoneNumber = "+375 (29) 111-22-33",
                Country = "Канада",
                City = "Аттава",
                DateOfBirth = DateTime.Parse("1964-09-02T19:20:25.988Z"),
                Gender = 1,
                Position = "Разработчик",
                Password = "Kiany123",
                Description = "Я Киану Ривз, дитя EPAMа занимаюсь разработкой 25 лет",
                CvUri = "",
                ImageUri = ""
            },

            new Specialist() {
                Id = Guid.Parse("1b6cfca3-96cf-4d5f-a1d4-12b8a00e8f7b"),
                Name = "Джасей",
                Surname = "Дуэйн",
                Patronymic = "Рикардо",
                Email = "jahseh@gmail.com",
                NormalizedEmail = "jahseh@gmail.com",
                PhoneNumber = "+375 (29) 111-22-34",
                Country = "США",
                City = "Брауард",
                DateOfBirth = DateTime.Parse("1998-01-23T19:20:25.988Z"),
                Gender = 1,
                Position = "Разработчик",
                Password = "Jahseh123",
                Description = "Стажер, клянусь своей жизнью, что сделаю вам офигительного бота",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("f39abfe8-786f-4b3a-8d86-4d684e729aa6"),
                Name = "Дарья",
                Surname = "Зотеева",
                Patronymic = "Евгеньевна",
                PhoneNumber = "+375 (29) 111-22-44",
                Email = "darya@gmail.com",
                NormalizedEmail = "darya@gmail.com",
                City = "Тобольск",
                Country = "Россия",
                Password = "Darya123",
                DateOfBirth = DateTime.Parse("2000-05-11T19:20:25.988Z"),
                Gender = 2,
                Position = "Аналитик",
                Description = "За деньги да, мечу на главного бизнес-аналитика",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("bd50b4c5-98ab-4d2b-974d-07e53c3cb627"),
                Name = "Билл",
                Surname = "Каулиц",
                Patronymic = "Симонович",
                PhoneNumber = "+375 (29) 111-22-45",
                Email = "bill@gmail.com",
                NormalizedEmail = "bill@gmail.com",
                City = "Лейпциг",
                Country = "ГДР",
                Password = "Bill1234",
                DateOfBirth = DateTime.Parse("1989-09-01T19:20:25.988Z"),
                Gender = 1,
                Position = "Дизайнер",
                Description = "Коллаборацию с McDonald's сделал и дизайн в figma сделаю",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("e8b52180-e2e0-4461-9bf3-372d19d5f28c"),
                Name = "Илай",
                Surname = "Московиц",
                Patronymic = "Ястребович",
                PhoneNumber = "+375 (29) 111-33-11",
                Email = "eli@gmail.com",
                NormalizedEmail = "eli@gmail.com",
                City = "Сан-Фернандо",
                Country = "США",
                Password = "Eli12345",
                DateOfBirth = DateTime.Parse("2003-11-01T19:20:25.988Z"),
                Gender = 1,
                Position = "Дизайнер",
                Description = "Могу отмудохать вам дизайн или лицо. Стаж 2 года",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("6d028d9d-9378-4db4-8d87-35b7f3d8d973"),
                Name = "Бонни",
                Surname = "Беннет",
                Patronymic = "Ведьмовна",
                PhoneNumber = "+375 (33) 666-66-66",
                Email = "bonbon@gmail.com",
                NormalizedEmail = "bonbon@gmail.com",
                City = "Мистик-Фоллс",
                Country = "США",
                Password = "Bon12345",
                DateOfBirth = DateTime.Parse("1993-10-31T19:20:25.988Z"),
                Gender = 2,
                Position = "Разработчик",
                Description = "Если вам не понравится, наведу порчу на понос))",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("ae41a12f-3c43-4a6e-b1b1-5452e676ed98"),
                Name = "Михаил",
                Surname = "Горшенёв",
                Patronymic = "Юрьевич",
                PhoneNumber = "+375 (29) 777-77-77",
                Email = "michail@gmail.com",
                NormalizedEmail = "michail@gmail.com",
                City = "Пикалево",
                Country = "Россия",
                Password = "Michail1",
                DateOfBirth = DateTime.Parse("1973-09-07T19:20:25.988Z"),
                Gender = 1,
                Position = "Дизайнер",
                Description = "Старший дизайнер, стаж 20 лет. Сделаю живой дизайн",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("cdff6b4b-4a2a-4927-b9e5-80154f893539"),
                Name = "Олеся",
                Surname = "Иванченко",
                Patronymic = "Игоревна",
                PhoneNumber = "+375 (44) 375-73-96",
                Email = "Olesya@gmail.com",
                NormalizedEmail = "olesya@gmail.com",
                City = "Краснодар",
                Country = "Россия",
                Password = "Olesya2345",
                DateOfBirth = DateTime.Parse("1995-07-25T19:20:25.988Z"),
                Gender = 2,
                Position = "Разработчик",
                Description = "Проект будет готов к 32 числу месяца",
                CvUri = "",
                ImageUri = ""
            },
            new Specialist() {
                Id = Guid.Parse("6a422a99-b975-485f-a95e-c1449a4d3622"),
                Name = "Ксения",
                Surname = "Собчак",
                Patronymic = "Анатольевна",
                PhoneNumber = "+375 (44) 947-83-63",
                Email = "Ksenia@gmail.com",
                NormalizedEmail = "ksenia@gmail.com",
                City = "Ленинград",
                Country = "Россия",
                Password = "Ksenia2345",
                DateOfBirth = DateTime.Parse("1991-11-05T19:20:25.988Z"),
                Gender = 2,
                Position = "Бизнес-аналитик",
                Description = "Думаете как старший аналитик я не смогу справиться с вашим заказом? " +
                              "Да я даже в президенты баллотировалась",
                CvUri = "",
                ImageUri = ""
            }
        ]);
    }
}

