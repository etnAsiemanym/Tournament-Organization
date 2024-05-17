using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tournament_Organization.Migrations
{
    /// <inheritdoc />
    public partial class InsertedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5e644a87-8a86-42e8-8aed-e6aee17459a8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e5b7352-6449-48db-aded-94b5ba381bab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dd45066c-99cf-4349-8be1-fd5322a77834");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fd0e16b6-2390-4c03-9a39-2052e64edfb4");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6494193a-8392-48b2-95b1-7844d79c0fdd", null, "Visitor", "VISITOR" },
                    { "fadfaa1e-a03c-4f8c-94f7-2c2af21e0e7d", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "68e90c89-ad89-49f3-b561-7e8af4cc94e7", 0, "4a409a13-352f-4545-9f5c-b9088b2c3dc9", null, false, "Anna", "Simmons", false, null, null, null, null, null, false, "57a298c7-c33c-4650-a94f-e74f4d209696", false, null },
                    { "8e95fccc-8e7e-4807-a795-d461bef5c3f3", 0, "a8a4a950-f49d-4ac6-a3e8-2115329e2195", null, false, "Mark", "Miens", false, null, null, null, null, null, false, "10793546-6983-42c5-8fe3-826fdf696eec", false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6494193a-8392-48b2-95b1-7844d79c0fdd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fadfaa1e-a03c-4f8c-94f7-2c2af21e0e7d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "68e90c89-ad89-49f3-b561-7e8af4cc94e7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8e95fccc-8e7e-4807-a795-d461bef5c3f3");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e644a87-8a86-42e8-8aed-e6aee17459a8", null, "Administrator", "ADMINISTRATOR" },
                    { "9e5b7352-6449-48db-aded-94b5ba381bab", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dd45066c-99cf-4349-8be1-fd5322a77834", 0, "8c29d5d1-e199-4c3b-bcd3-d404b5be6c72", null, false, "Anna", "Simmons", false, null, null, null, null, null, false, "0919b53a-5a48-465d-b8e1-069926d5b4aa", false, null },
                    { "fd0e16b6-2390-4c03-9a39-2052e64edfb4", 0, "18538f08-1c06-419c-8fab-7db06295baf9", null, false, "Mark", "Miens", false, null, null, null, null, null, false, "cf945a84-6354-4d07-b9bc-59ec79770e4f", false, null }
                });
        }
    }
}
