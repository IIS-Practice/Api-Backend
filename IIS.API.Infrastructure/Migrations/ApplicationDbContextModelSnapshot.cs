﻿// <auto-generated />
using System;
using IIS.API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IIS.API.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IIS.API.Domain.Entities.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Complexity")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cases", (string)null);
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Faq", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faqs", (string)null);
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews", (string)null);
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Complexity")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Serveces", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb7221d0-35e3-4e52-a6cf-3a5f6b1611d5"),
                            Complexity = 5,
                            Cost = 159m,
                            Description = "description 1",
                            Name = "service 1"
                        },
                        new
                        {
                            Id = new Guid("b223cbcc-d2b7-4b27-97eb-1a5b2c09acd1"),
                            Complexity = 3,
                            Cost = 109m,
                            Description = "description 2",
                            Name = "service 2"
                        });
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail", "Password")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = new Guid("68bf8340-f170-46de-ac5f-5a7f59f2103e"),
                            City = "City 1",
                            Country = "Country 1",
                            DateOfBirth = new DateTime(2004, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6687),
                            Email = "email1@gmail.com",
                            Gender = 1,
                            Name = "Name 1",
                            NormalizedEmail = "email1@gmail.com",
                            Password = "Qq12345678qQ",
                            Patronymic = "Patronymic 1",
                            PhoneNumber = "+375 (29) 111-11-11",
                            Surname = "Surname 1"
                        },
                        new
                        {
                            Id = new Guid("afb6a935-00ce-45fc-95b6-5f807d92a95e"),
                            City = "City 2",
                            Country = "Country 2",
                            DateOfBirth = new DateTime(1974, 6, 13, 15, 3, 6, 547, DateTimeKind.Local).AddTicks(6701),
                            Email = "email2@gmail.com",
                            Gender = 2,
                            Name = "Name 2",
                            NormalizedEmail = "email2@gmail.com",
                            Password = "Qq12345678qQ",
                            Patronymic = "Patronymic 2",
                            PhoneNumber = "+375 (29) 222-22-22",
                            Surname = "Surname 2"
                        });
                });

            modelBuilder.Entity("ServiceCases", b =>
                {
                    b.Property<Guid>("CaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CaseId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServiceCases");
                });

            modelBuilder.Entity("ServiceSpecialists", b =>
                {
                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SpecialistId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ServiceId", "SpecialistId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("ServiceSpecialists");
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Specialist", b =>
                {
                    b.HasBaseType("IIS.API.Domain.Entities.User");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Specialist");
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Review", b =>
                {
                    b.HasOne("IIS.API.Domain.Entities.Case", null)
                        .WithMany("Rewiews")
                        .HasForeignKey("CaseId");

                    b.HasOne("IIS.API.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ServiceCases", b =>
                {
                    b.HasOne("IIS.API.Domain.Entities.Case", null)
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS.API.Domain.Entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceSpecialists", b =>
                {
                    b.HasOne("IIS.API.Domain.Entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IIS.API.Domain.Entities.Specialist", null)
                        .WithMany()
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IIS.API.Domain.Entities.Case", b =>
                {
                    b.Navigation("Rewiews");
                });
#pragma warning restore 612, 618
        }
    }
}
