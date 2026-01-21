using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FurryFriendsAdoption.Migrations
{
    /// <inheritdoc />
    public partial class Appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac719270-e4eb-4769-ae9a-fb3558d9bc8b", "AQAAAAIAAYagAAAAEIAxtjagPA2TtWyEvHw8K8KW4i3BEJEYQ/QOkUg+bfvIxgHcPDC4JCIzqCm8HglUfQ==", "b94ff202-cb02-4f16-bfb1-796ac0ba27fa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb187763-bc5a-4ec2-9d7f-175a6278afe3", "AQAAAAIAAYagAAAAEItMt57YdIItrWYxub7tkdqZ+fttzvLX50YJcnj6+ZiCykDtntkgLyvDt4hMqIHBOQ==", "cf110332-40b9-4a03-8fb0-b05b48a97083" });
        }
    }
}
