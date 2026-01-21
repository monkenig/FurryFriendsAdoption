using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class FixEnumStatusMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                values: new object[] { "d796a4f4-0689-4b28-8a4a-1eaeb95c12c4", "AQAAAAIAAYagAAAAEIXkM3uNsqoLBK3cgmDYD5LI9wnGFoPrSTxd8uV8ElC/hkBOxCsiamy4QcL0VE0+Nw==", "2377e4ff-2cd6-430c-a1dd-3f43a0627a7a" });

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_CustomerId",
                table: "AdoptionApplication",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AdoptionApplication_PetId",
                table: "AdoptionApplication",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionApplication_Customer_CustomerId",
                table: "AdoptionApplication",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdoptionApplication_Pet_PetId",
                table: "AdoptionApplication",
                column: "PetId",
                principalTable: "Pet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionApplication_Customer_CustomerId",
                table: "AdoptionApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_AdoptionApplication_Pet_PetId",
                table: "AdoptionApplication");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionApplication_CustomerId",
                table: "AdoptionApplication");

            migrationBuilder.DropIndex(
                name: "IX_AdoptionApplication_PetId",
                table: "AdoptionApplication");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Appointment",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
