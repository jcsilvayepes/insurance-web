using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class UpdatingPolicyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentageCoverage",
                table: "CoverageByPolicy");

            migrationBuilder.AddColumn<double>(
                name: "PercentageCoverage",
                table: "Insurances",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentageCoverage",
                table: "Insurances");

            migrationBuilder.AddColumn<double>(
                name: "PercentageCoverage",
                table: "CoverageByPolicy",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
