using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class FixAppointmentRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97a8499-403b-4a6b-b71f-f858548d68e5", "AQAAAAIAAYagAAAAED0kjvd9Nzsi/bWjCHH7RgzYLJ7uiNEFBecxveYl54byoK0yMml2X8aw5gBANFxarA==", "11857d7e-e686-47f2-be55-613c0f078dc1" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PetId",
                table: "Appointment",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Pet_PetId",
                table: "Appointment",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer_CustomerId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Pet_PetId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_PetId",
                table: "Appointment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b98e375-001d-46a2-a74f-6043463eeee1", "AQAAAAIAAYagAAAAENSxkSTYN9IlGDXscW3OwcjPWXaHZ0U9TdUwF118Ys2aLBb7zkF0jJNzwZ3q/rc8DQ==", "68e3e91d-8de2-47b6-a671-2a7159a1e32c" });
        }
    }
}
