using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class MoreUsersSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "FirstName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6801c519-58d3-4ad8-8e45-97e901573495", true, "Петър", "Петров", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEKkMfBwWGvqD6v8LFi1ntMCuULRPbQu+C8SVp4WS7O8/Kk6B4i67qShnIp7Hi595eQ==", "6bb17bfa-8893-4044-984c-8af66e5bc0bc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "57323aaa-f541-49d5-acff-f387440cd033", 0, "2ded9935-42e2-4380-9880-2a0e6eeb87db", "client2@mail.com", true, "Георги", "Георгиев", false, null, "CLIENT2@MAIL.COM", "CLIENT2", "AQAAAAIAAYagAAAAEM39Ia0HWNNEQkyccx0KFczZU8Cdt3S53Jnxjc/XOe6RbaRw6hubCNi0QMl5cdaKiA==", "0888888888", false, "7104a71c-0450-40df-98ef-267c63341abf", false, "client2" },
                    { "a94432c6-6f4c-4e54-b3fd-ade9649ea26a", 0, "f1e71e27-2944-4baa-aa36-6d8b4718461f", "agent2@mail.com", false, "Ангел", "Ангелов", false, null, "AGENT2@MAIL.COM", "AGENT2", "AQAAAAIAAYagAAAAEHGtNt6OQHXX0taVWZpUu+dGUDoFf8Db4ix/cJvcOlEhAqiUeCNPn35ARC5GN2nQ5w==", "0888888888", false, "e66112f8-bd4b-4c2d-9b0b-99a6efa7f400", false, "agent2" },
                    { "aa85aebf-98df-4aac-9b93-578664d43b8a", 0, "7b042264-415f-4b84-96a2-d159ce5052b9", "agent1@mail.com", true, "Иван", "Иванов", false, null, "AGENT1@MAIL.COM", "AGENT1", "AQAAAAIAAYagAAAAENKqk26xeHCZckjzgWy6qhaHBBREASwqeiDDPAOYHNqTD5bI0ZIM8pior/a1UDvJ2A==", "0888888888", false, "f0d73df1-7c12-4862-80cb-69a2d3fa95d7", false, "agent1" },
                    { "b72a2e9e-5e12-46a4-a463-4fb3689c95a6", 0, "b5dce679-479b-43e6-bc14-f27171e2556b", "client1@mail.com", true, "Борис", "Борисов", false, null, "CLIENT1@MAIL.COM", "CLIENT1", "AQAAAAIAAYagAAAAEO+jSGrDx+GrHlmxxybe0r4DE9mfpGaPkN56F8Uxcft4FAAJY+seETUdA7/2lTblBQ==", "0888888888", false, "52dc607d-d7da-48d6-a1f7-046e15791b7a", false, "client1" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "OfficeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("96df0fcd-5578-4faa-895d-66b1cebed911"), new Guid("cf3f3ba8-6459-41c5-8bf5-49992f623c77"), "a94432c6-6f4c-4e54-b3fd-ade9649ea26a" },
                    { new Guid("cf7abbd6-b1b9-4056-88a8-7cc76315e186"), new Guid("e0a76579-d653-4ab5-8044-db85da0567df"), "aa85aebf-98df-4aac-9b93-578664d43b8a" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BirthDate", "CityId", "MiddleName", "UserId" },
                values: new object[,]
                {
                    { new Guid("82819ff0-3697-4e2f-af83-2db578a23813"), new DateTime(2005, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("53142745-f66f-4f08-95a1-b8e961c73f05"), "Петков", "b72a2e9e-5e12-46a4-a463-4fb3689c95a6" },
                    { new Guid("d999134f-b7dc-4fc1-ad10-b2035d9fff41"), new DateTime(1989, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38605449-8d0a-48d4-8870-cf6b703ada63"), "Николаев", "57323aaa-f541-49d5-acff-f387440cd033" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: new Guid("96df0fcd-5578-4faa-895d-66b1cebed911"));

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: new Guid("cf7abbd6-b1b9-4056-88a8-7cc76315e186"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("82819ff0-3697-4e2f-af83-2db578a23813"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("d999134f-b7dc-4fc1-ad10-b2035d9fff41"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57323aaa-f541-49d5-acff-f387440cd033");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a94432c6-6f4c-4e54-b3fd-ade9649ea26a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa85aebf-98df-4aac-9b93-578664d43b8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b72a2e9e-5e12-46a4-a463-4fb3689c95a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "FirstName", "LastName", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306409d8-ed85-493f-b442-bed70bd9b655", false, "Petar", "Petrov", " ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAECzZhJ94+Rad3IQZhpx0HpKjiFj5g8BWTrIc6LXeTfNdZgPzR+xNs4rmlWXo7klYDA==", "c788221b-8b77-4ea7-b956-a003756ab51e" });
        }
    }
}
