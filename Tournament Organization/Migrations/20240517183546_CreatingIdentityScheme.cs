using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tournament_Organization.Migrations
{
    /// <inheritdoc />
    public partial class CreatingIdentityScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "97bf2a88-abee-4b0f-b9b5-14669708f12f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b5911064-f882-45d2-8685-cc7f76093588");

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dd45066c-99cf-4349-8be1-fd5322a77834");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fd0e16b6-2390-4c03-9a39-2052e64edfb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "97bf2a88-abee-4b0f-b9b5-14669708f12f", 0, "671a6baf-e81f-4958-8bae-ab4716c5b710", null, false, "Anna", "Simmons", false, null, null, null, null, null, false, "9cfc1af0-c962-4bd7-9a87-ad927fff05c8", false, null },
                    { "b5911064-f882-45d2-8685-cc7f76093588", 0, "d25b2bea-a4c0-482e-b85f-c8e142a5d158", null, false, "Mark", "Miens", false, null, null, null, null, null, false, "57fdd18f-5fca-4936-8719-1a8563368c16", false, null }
                });
        }
    }
}
