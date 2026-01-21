using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddPetCategoryView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef16e009-7539-4126-ab15-8e32110edef9", "AQAAAAIAAYagAAAAEAbyzkbaHBpoWKsQPkz+h+4DnvNOGlgDANOkJv8P66P4udFZotpPs9sCwKAV5OR1/g==", "6d7c5d9a-719a-4b23-b2fd-5bd1d6a1133c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c772e3ad-d9d2-44b7-a7e8-ff952abc0ab2", "AQAAAAIAAYagAAAAEDMiTr3W6b0BuOsZJUX6t6KXFergW3/W8cljNgaqUrAplDPtThk78RadOS9xuVivyA==", "86d37201-b319-4fee-9b75-eeec9286477f" });
        }
    }
}
