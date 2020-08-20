using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    public partial class PolicyEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurances_PolicyCoverageTypeEntity_InsuranceCoverageTypeId",
                table: "Insurances");

            migrationBuilder.DropIndex(
                name: "IX_Insurances_InsuranceCoverageTypeId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "CoverageMonth",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "InsuranceCoverageTypeId",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "InsurancePrice",
                table: "Insurances");

            migrationBuilder.AddColumn<int>(
                name: "Coverage",
                table: "Insurances",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PolicyCoverageTypeId",
                table: "Insurances",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PolicyPrice",
                table: "Insurances",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PolicyPrice",
                table: "Insurances");

            migrationBuilder.AddColumn<int>(
                name: "CoverageMonth",
                table: "Insurances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsuranceCoverageTypeId",
                table: "Insurances",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "InsurancePrice",
                table: "Insurances",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_InsuranceCoverageTypeId",
                table: "Insurances",
                column: "InsuranceCoverageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurances_PolicyCoverageTypeEntity_InsuranceCoverageTypeId",
                table: "Insurances",
                column: "InsuranceCoverageTypeId",
                principalTable: "PolicyCoverageTypeEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
