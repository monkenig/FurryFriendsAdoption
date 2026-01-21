using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAndIdentityLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb187763-bc5a-4ec2-9d7f-175a6278afe3", "AQAAAAIAAYagAAAAEItMt57YdIItrWYxub7tkdqZ+fttzvLX50YJcnj6+ZiCykDtntkgLyvDt4hMqIHBOQ==", "cf110332-40b9-4a03-8fb0-b05b48a97083" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsVaccinated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsVaccinated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsVaccinated",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Customer");

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
    }
}
