using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class ModifyingPolicyEntitystructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_PolicyCoverageTypeEntity_PolicyCoverageTypeId",
                table: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_PolicyCoverageTypeId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "Coverage",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "PolicyCoverageTypeId",
                table: "Insurances");

            migrationBuilder.CreateTable(
                name: "CoverageByPolicy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyCoverageTypeId = table.Column<int>(nullable: false),
                    InsuranceId = table.Column<int>(nullable: false),
                    PercentageCoverage = table.Column<double>(nullable: false),
                    PolicyEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverageByPolicy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoverageByPolicy_PolicyCoverageTypeEntity_PolicyCoverageTypeId",
                        column: x => x.PolicyCoverageTypeId,
                        principalTable: "PolicyCoverageTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoverageByPolicy_Insurances_PolicyEntityId",
                        column: x => x.PolicyEntityId,
                        principalTable: "Insurances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoverageByPolicy_PolicyCoverageTypeId",
                table: "CoverageByPolicy",
                column: "PolicyCoverageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CoverageByPolicy_PolicyEntityId",
                table: "CoverageByPolicy",
                column: "PolicyEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoverageByPolicy");

            migrationBuilder.AddColumn<int>(
                name: "Coverage",
                table: "Insurances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PolicyCoverageTypeId",
                table: "Insurances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_PolicyCoverageTypeId",
                table: "Insurances",
                column: "PolicyCoverageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_PolicyCoverageTypeEntity_PolicyCoverageTypeId",
                table: "Insurances",
                column: "PolicyCoverageTypeId",
                principalTable: "PolicyCoverageTypeEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
