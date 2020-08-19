using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolicyCoverageTypeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyCoverageTypeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskTypeEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTypeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InsuranceCoverageTypeId = table.Column<int>(nullable: true),
                    Validity = table.Column<int>(nullable: false),
                    CoverageMonth = table.Column<int>(nullable: false),
                    InsurancePrice = table.Column<double>(nullable: false),
                    RiskTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurances_PolicyCoverageTypeEntity_InsuranceCoverageTypeId",
                        column: x => x.InsuranceCoverageTypeId,
                        principalTable: "PolicyCoverageTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Insurances_RiskTypeEntity_RiskTypeId",
                        column: x => x.RiskTypeId,
                        principalTable: "RiskTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_InsuranceCoverageTypeId",
                table: "Insurances",
                column: "InsuranceCoverageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_RiskTypeId",
                table: "Insurances",
                column: "RiskTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "PolicyCoverageTypeEntity");

            migrationBuilder.DropTable(
                name: "RiskTypeEntity");
        }
    }
}
