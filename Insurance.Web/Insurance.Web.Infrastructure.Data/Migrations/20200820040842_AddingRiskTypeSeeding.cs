using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class AddingRiskTypeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RiskTypeEntity",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Mid" },
                    { 3, "Mid-low" },
                    { 4, "High" }
                });
        }

        #region Seedings
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RiskTypeEntity",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RiskTypeEntity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RiskTypeEntity",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RiskTypeEntity",
                keyColumn: "Id",
                keyValue: 4);
        }
        #endregion

    }
}
