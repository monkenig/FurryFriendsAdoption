using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentRejectionReason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "142caa24-d8a6-4347-a0d0-14546cd2e7bb", "AQAAAAIAAYagAAAAEJOdKdacq5C6OJJGZBgV+5d3onX9FwOyu2FxPkY0Qs9754j2C5erRA31duJjWCSYvQ==", "7708912d-1802-4720-9384-a3184a737601" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "Appointment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e3a662d-044b-4b0e-9325-b8b5a64de5bf", "AQAAAAIAAYagAAAAEDjwD2Q4/b3KRX3B6eoV8MEi7PH/lSPaLOOFcd0Y+LHgJlr82WyXKAwUWhkXDbA74Q==", "26de2926-83c4-4efc-aa70-2e5a634a514c" });
        }
    }
}
