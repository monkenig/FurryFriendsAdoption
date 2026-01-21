using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class FixEnumStatusStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e3a662d-044b-4b0e-9325-b8b5a64de5bf", "AQAAAAIAAYagAAAAEDjwD2Q4/b3KRX3B6eoV8MEi7PH/lSPaLOOFcd0Y+LHgJlr82WyXKAwUWhkXDbA74Q==", "26de2926-83c4-4efc-aa70-2e5a634a514c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d796a4f4-0689-4b28-8a4a-1eaeb95c12c4", "AQAAAAIAAYagAAAAEIXkM3uNsqoLBK3cgmDYD5LI9wnGFoPrSTxd8uV8ElC/hkBOxCsiamy4QcL0VE0+Nw==", "2377e4ff-2cd6-430c-a1dd-3f43a0627a7a" });
        }
    }
}
