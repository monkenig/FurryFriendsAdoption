using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddAdoptionApplicationRejectionReason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "AdoptionApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c772e3ad-d9d2-44b7-a7e8-ff952abc0ab2", "AQAAAAIAAYagAAAAEDMiTr3W6b0BuOsZJUX6t6KXFergW3/W8cljNgaqUrAplDPtThk78RadOS9xuVivyA==", "86d37201-b319-4fee-9b75-eeec9286477f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "AdoptionApplication");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "142caa24-d8a6-4347-a0d0-14546cd2e7bb", "AQAAAAIAAYagAAAAEJOdKdacq5C6OJJGZBgV+5d3onX9FwOyu2FxPkY0Qs9754j2C5erRA31duJjWCSYvQ==", "7708912d-1802-4720-9384-a3184a737601" });
        }
    }
}
