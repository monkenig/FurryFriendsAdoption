using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentStatusEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Appointment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b98e375-001d-46a2-a74f-6043463eeee1", "AQAAAAIAAYagAAAAENSxkSTYN9IlGDXscW3OwcjPWXaHZ0U9TdUwF118Ys2aLBb7zkF0jJNzwZ3q/rc8DQ==", "68e3e91d-8de2-47b6-a671-2a7159a1e32c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac719270-e4eb-4769-ae9a-fb3558d9bc8b", "AQAAAAIAAYagAAAAEIAxtjagPA2TtWyEvHw8K8KW4i3BEJEYQ/QOkUg+bfvIxgHcPDC4JCIzqCm8HglUfQ==", "b94ff202-cb02-4f16-bfb1-796ac0ba27fa" });
        }
    }
}
