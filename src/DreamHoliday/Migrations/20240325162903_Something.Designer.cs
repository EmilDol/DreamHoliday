﻿// <auto-generated />
using System;
using DreamHoliday.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DreamHoliday.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240325162903_Something")]
    partial class Something
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Agent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf7abbd6-b1b9-4056-88a8-7cc76315e186"),
                            OfficeId = new Guid("e0a76579-d653-4ab5-8044-db85da0567df"),
                            UserId = "aa85aebf-98df-4aac-9b93-578664d43b8a"
                        },
                        new
                        {
                            Id = new Guid("96df0fcd-5578-4faa-895d-66b1cebed911"),
                            OfficeId = new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"),
                            UserId = "a94432c6-6f4c-4e54-b3fd-ade9649ea26a"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b987b4f-ae14-43ba-9d7e-b29fcb1c1acf",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Петър",
                            LastName = "Петров",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEIl05pKIQnEFKGzd7haDxxbyz+0z0ZJTA3cI74MbfutOvjzErcRATGKHIa30a7e41w==",
                            PhoneNumber = "0888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d680e897-027f-4677-b150-79f3a4d19427",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "aa85aebf-98df-4aac-9b93-578664d43b8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1ad668fd-738a-441c-b79c-157b4ba9d7a8",
                            Email = "agent1@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Иван",
                            LastName = "Иванов",
                            LockoutEnabled = false,
                            NormalizedEmail = "AGENT1@MAIL.COM",
                            NormalizedUserName = "AGENT1",
                            PasswordHash = "AQAAAAIAAYagAAAAEHWuUEMeqnI+gYugkpf6x5/xMjvnyiisJ3U4YPgklFZJZwHie8Aqjn+vRTmdA7SCGA==",
                            PhoneNumber = "0888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ab15d9d4-0845-4595-a422-aab48ead6430",
                            TwoFactorEnabled = false,
                            UserName = "agent1"
                        },
                        new
                        {
                            Id = "a94432c6-6f4c-4e54-b3fd-ade9649ea26a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17600ef4-f44e-465b-bfc5-b056955c70fd",
                            Email = "agent2@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Ангел",
                            LastName = "Ангелов",
                            LockoutEnabled = false,
                            NormalizedEmail = "AGENT2@MAIL.COM",
                            NormalizedUserName = "AGENT2",
                            PasswordHash = "AQAAAAIAAYagAAAAENGsi/NLWUjjJMME18xVxgX9t7UhhfyGRUuVLs4gjf2TG9xUctKImXGTWmRYO6EQrw==",
                            PhoneNumber = "0888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6b5ad5fa-1c73-4884-b7dc-3554c6c5f755",
                            TwoFactorEnabled = false,
                            UserName = "agent2"
                        },
                        new
                        {
                            Id = "b72a2e9e-5e12-46a4-a463-4fb3689c95a6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0c95934-e82a-4a1c-a655-a8d825b0c136",
                            Email = "client1@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Борис",
                            LastName = "Борисов",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT1@MAIL.COM",
                            NormalizedUserName = "CLIENT1",
                            PasswordHash = "AQAAAAIAAYagAAAAEAJlN5WhRR8r7ljMz3ibdUbVJGushXNygC6bBBaXlzmYSv7R8xezqs0jQRA7kVRyPw==",
                            PhoneNumber = "0888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d20b9cef-a404-4e17-8c7a-2e8a14dcd9cc",
                            TwoFactorEnabled = false,
                            UserName = "client1"
                        },
                        new
                        {
                            Id = "57323aaa-f541-49d5-acff-f387440cd033",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d7a33c05-7f33-4b4d-9465-f817763de747",
                            Email = "client2@mail.com",
                            EmailConfirmed = true,
                            FirstName = "Георги",
                            LastName = "Георгиев",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT2@MAIL.COM",
                            NormalizedUserName = "CLIENT2",
                            PasswordHash = "AQAAAAIAAYagAAAAEC4HpSaRrYnom21sPoOjOnH4Vty22EKO0VssAI6w1fmNUfkapC1sUE8IhPD5EOF3rg==",
                            PhoneNumber = "0888888888",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba3ad7c3-5884-43bd-8d07-a954ee4f6214",
                            TwoFactorEnabled = false,
                            UserName = "client2"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDestination")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"),
                            CountryId = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                            IsDestination = false,
                            Name = "Велико Търново"
                        },
                        new
                        {
                            Id = new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"),
                            CountryId = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                            IsDestination = true,
                            Name = "Варна"
                        },
                        new
                        {
                            Id = new Guid("73fdbbb6-d252-4bc2-998c-fae2ed240555"),
                            CountryId = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                            IsDestination = false,
                            Name = "Букурещ"
                        },
                        new
                        {
                            Id = new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"),
                            CountryId = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                            IsDestination = true,
                            Name = "Тимишоара"
                        },
                        new
                        {
                            Id = new Guid("63d7784d-6714-42ed-896a-73346ba66044"),
                            CountryId = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                            IsDestination = true,
                            Name = "Атина"
                        },
                        new
                        {
                            Id = new Guid("dc2c8910-e342-4a07-9197-0dbde7061905"),
                            CountryId = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                            IsDestination = true,
                            Name = "Солун"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("82819ff0-3697-4e2f-af83-2db578a23813"),
                            BirthDate = new DateTime(2005, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"),
                            MiddleName = "Петков",
                            UserId = "b72a2e9e-5e12-46a4-a463-4fb3689c95a6"
                        },
                        new
                        {
                            Id = new Guid("d999134f-b7dc-4fc1-ad10-b2035d9fff41"),
                            BirthDate = new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityId = new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"),
                            MiddleName = "Николаев",
                            UserId = "57323aaa-f541-49d5-acff-f387440cd033"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"),
                            Name = "България",
                            PhoneCode = "+359"
                        },
                        new
                        {
                            Id = new Guid("86811293-072c-459c-953e-02a9a3597d11"),
                            Name = "Румъния",
                            PhoneCode = "+40"
                        },
                        new
                        {
                            Id = new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"),
                            Name = "Гърция",
                            PhoneCode = "+30"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e0a76579-d653-4ab5-8044-db85da0567df"),
                            Address = "ул. \"Баба Мота\" № 3",
                            CityId = new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"),
                            Number = 1101,
                            PhoneNumber = "0888888888"
                        },
                        new
                        {
                            Id = new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"),
                            Address = "ул. \"Гео Милев\" № 5",
                            CityId = new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"),
                            Number = 1201,
                            PhoneNumber = "0888888888"
                        });
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Rating", b =>
                {
                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "HotelId");

                    b.HasIndex("HotelId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AgentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CancellingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LateDeparture")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("ClientId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AdultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<decimal>("ChildBelow12Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ChildBelow7Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DoubleBeds")
                        .HasColumnType("int");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SingleBeds")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Agent", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.Office", "Office")
                        .WithMany("Agents")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", "User")
                        .WithOne("Agent")
                        .HasForeignKey("DreamHoliday.Data.DbModels.Agent", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.City", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Client", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.City", "City")
                        .WithMany("Clients")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", "User")
                        .WithOne("Client")
                        .HasForeignKey("DreamHoliday.Data.DbModels.Client", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Hotel", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.City", "City")
                        .WithMany("Hotels")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Office", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.City", "City")
                        .WithMany("Offices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Rating", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.Client", "Client")
                        .WithMany("Ratings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.Hotel", "Hotel")
                        .WithMany("Ratings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Reservation", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.Agent", "Agent")
                        .WithMany("Reservations")
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Client");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Room", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DreamHoliday.Data.DbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Agent", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.ApplicationUser", b =>
                {
                    b.Navigation("Agent");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.City", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Hotels");

                    b.Navigation("Offices");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Client", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Hotel", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Office", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("DreamHoliday.Data.DbModels.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
