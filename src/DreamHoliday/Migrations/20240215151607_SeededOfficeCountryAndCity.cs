using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class SeededOfficeCountryAndCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306409d8-ed85-493f-b442-bed70bd9b655", "AQAAAAIAAYagAAAAECzZhJ94+Rad3IQZhpx0HpKjiFj5g8BWTrIc6LXeTfNdZgPzR+xNs4rmlWXo7klYDA==", "c788221b-8b77-4ea7-b956-a003756ab51e" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "PhoneCode" },
                values: new object[,]
                {
                    { new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"), "Гърция", "+30" },
                    { new Guid("86811293-072c-459c-953e-02a9a3597d11"), "Румъния", "+40" },
                    { new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"), "България", "+359" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"), new Guid("86811293-072c-459c-953e-02a9a3597d11"), "Тимишоара" },
                    { new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"), new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"), "Велико Търново" },
                    { new Guid("63d7784d-6714-42ed-896a-73346ba66044"), new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"), "Атина" },
                    { new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"), new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"), "Варна" },
                    { new Guid("73fdbbb6-d252-4bc2-998c-fae2ed240555"), new Guid("86811293-072c-459c-953e-02a9a3597d11"), "Букурещ" },
                    { new Guid("dc2c8910-e342-4a07-9197-0dbde7061905"), new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"), "Солун" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "Address", "CityId", "Number", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"), "ул. \"Гео Милев\" № 5", new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"), 1201, "0888888888" },
                    { new Guid("e0a76579-d653-4ab5-8044-db85da0567df"), "ул. \"Баба Мота\" № 3", new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"), 1101, "0888888888" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("63d7784d-6714-42ed-896a-73346ba66044"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("73fdbbb6-d252-4bc2-998c-fae2ed240555"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("dc2c8910-e342-4a07-9197-0dbde7061905"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("e0a76579-d653-4ab5-8044-db85da0567df"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("698f99e7-a344-44a0-957c-a98ce4eccbaf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3473a25e-0aa4-42e4-9d9a-c4e6f8a2c567"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86811293-072c-459c-953e-02a9a3597d11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a3786a9-2085-4205-9749-109bb6f00d93"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b62ef3ad-f357-4706-af36-318651b939e0", "AQAAAAIAAYagAAAAEAgu/XnODiw0hnti2GKpXrztYedl8sLyn6GArbkAmnBj9r3WUhWyOCaGRLgn6jXvNQ==", "4b24664d-c15e-4798-9ed1-c506df77faab" });
        }
    }
}
