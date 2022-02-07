using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddadDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1be598e-c268-42f6-a9d5-d8607de72fcf", "025f0340-973f-4976-af8d-2ddfe72abda1", "User", "USER" },
                    { "6c23d463-db36-42c3-8253-1219d42de1c0", "152a3d02-5ec8-4583-94de-9db8a2b21ca9", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c23d463-db36-42c3-8253-1219d42de1c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1be598e-c268-42f6-a9d5-d8607de72fcf");

            
        }
    }
}
