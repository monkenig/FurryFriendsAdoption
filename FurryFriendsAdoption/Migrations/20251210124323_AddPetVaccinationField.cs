using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddPetVaccinationField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVaccinated",
                table: "Pet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a0f925-041d-4062-bcb9-29dac5f2fa08", "AQAAAAIAAYagAAAAELl+UILLIZVQGTljv2MOWbnBGdTZQwaRXcNjad796HUUWJ86ZzzzlY/gLW/Ktkyhfg==", "229da5d3-9887-4faa-b10e-bb2af51b5ec1" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsVaccinated",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsVaccinated",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsVaccinated",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVaccinated",
                table: "Pet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3fffc0d-1e13-4936-8540-503a8282132f", "AQAAAAIAAYagAAAAEBGIz7p+169AnXKNzi5MD+Al8RazQW/x8XioN4KxVJhNsL2yHrYmIyhBQSB85LSo6A==", "0ce34c91-853a-452b-be28-da6a6237a9ee" });
        }
    }
}
