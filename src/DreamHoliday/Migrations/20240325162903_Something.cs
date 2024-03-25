using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamHoliday.Migrations
{
    /// <inheritdoc />
    public partial class Something : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57323aaa-f541-49d5-acff-f387440cd033",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a33c05-7f33-4b4d-9465-f817763de747", "AQAAAAIAAYagAAAAEC4HpSaRrYnom21sPoOjOnH4Vty22EKO0VssAI6w1fmNUfkapC1sUE8IhPD5EOF3rg==", "ba3ad7c3-5884-43bd-8d07-a954ee4f6214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a94432c6-6f4c-4e54-b3fd-ade9649ea26a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17600ef4-f44e-465b-bfc5-b056955c70fd", "AQAAAAIAAYagAAAAENGsi/NLWUjjJMME18xVxgX9t7UhhfyGRUuVLs4gjf2TG9xUctKImXGTWmRYO6EQrw==", "6b5ad5fa-1c73-4884-b7dc-3554c6c5f755" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa85aebf-98df-4aac-9b93-578664d43b8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad668fd-738a-441c-b79c-157b4ba9d7a8", "AQAAAAIAAYagAAAAEHWuUEMeqnI+gYugkpf6x5/xMjvnyiisJ3U4YPgklFZJZwHie8Aqjn+vRTmdA7SCGA==", "ab15d9d4-0845-4595-a422-aab48ead6430" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b72a2e9e-5e12-46a4-a463-4fb3689c95a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0c95934-e82a-4a1c-a655-a8d825b0c136", "AQAAAAIAAYagAAAAEAJlN5WhRR8r7ljMz3ibdUbVJGushXNygC6bBBaXlzmYSv7R8xezqs0jQRA7kVRyPw==", "d20b9cef-a404-4e17-8c7a-2e8a14dcd9cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b987b4f-ae14-43ba-9d7e-b29fcb1c1acf", "AQAAAAIAAYagAAAAEIl05pKIQnEFKGzd7haDxxbyz+0z0ZJTA3cI74MbfutOvjzErcRATGKHIa30a7e41w==", "d680e897-027f-4677-b150-79f3a4d19427" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57323aaa-f541-49d5-acff-f387440cd033",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a33b2cb-6ec5-4cc9-8f29-217bed7cbb5d", "AQAAAAIAAYagAAAAEKe41A/LFSULEYSVG+EWDHij5XEvAGXTlo+M2dfZ3YxsopD1uCpQ+WKcUsC0zhmnOw==", "cd6875db-7da5-4525-b7d6-32feee8d36f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a94432c6-6f4c-4e54-b3fd-ade9649ea26a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7224b56-99e8-4f4d-a52b-8079c63bd18f", "AQAAAAIAAYagAAAAEMGvXE0Vd0EBXktK0uSTXdMLwiLZucRNjJzuT7kG6wJ1Hd1+p5Cmbla5xIhfJMqGaA==", "8b6ae274-2e16-4d54-814c-6405f18d094c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa85aebf-98df-4aac-9b93-578664d43b8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e24c4d18-d76d-4e50-a1f8-86783b0c076e", "AQAAAAIAAYagAAAAEEEHoWEsAGPQhbfavuQefkLr6jbnNZCLGOshH/+/2Ios+5APfeJW+febxaFw4WSt8g==", "09f09324-fbe0-48c7-8968-7c5233f32069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b72a2e9e-5e12-46a4-a463-4fb3689c95a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb268e70-66a8-4d0c-90b4-4255a91ce2cd", "AQAAAAIAAYagAAAAEGUkqT3y69uxI9rLU+HYdEhDDDi2ivNPwN7PDRJn8sZH9lQS/EO11IdKgdK4p13S0A==", "08f96284-bf29-4529-b8f1-da147655807e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b39207f-94f6-4f66-98e5-67c6e5173406", "AQAAAAIAAYagAAAAEMwQlBIBvIHgexa9YOf2s+pu70kfBYyXLaD9CKcE9lz/zpM6Eh1sck//E0WJtQzvxQ==", "82738f56-e596-48da-847f-4f0f895f9ec4" });
        }
    }
}
