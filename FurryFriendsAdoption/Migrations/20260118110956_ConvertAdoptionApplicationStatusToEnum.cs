using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class ConvertAdoptionApplicationStatusToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "AdoptionApplication",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208111fc-55b6-40b0-9d9c-730b4966631d", "AQAAAAIAAYagAAAAEBlKYnk76rd6Wd70pY2twqG27NjZwEI+in5byHCWg7vm7em3YQp3Jv02DK3fE2qh/A==", "a8849d52-3c5c-4bc8-b26b-797398b04385" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97a8499-403b-4a6b-b71f-f858548d68e5", "AQAAAAIAAYagAAAAED0kjvd9Nzsi/bWjCHH7RgzYLJ7uiNEFBecxveYl54byoK0yMml2X8aw5gBANFxarA==", "11857d7e-e686-47f2-be55-613c0f078dc1" });
        }
    }
}
