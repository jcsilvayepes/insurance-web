using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class AddingPolicyCoverageTypeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PolicyCoverageTypeEntity",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Earthquake" },
                    { 2, "Fire" },
                    { 3, "Theft" },
                    { 4, "Loss" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PolicyCoverageTypeEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageTypeEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageTypeEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PolicyCoverageTypeEntity",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
