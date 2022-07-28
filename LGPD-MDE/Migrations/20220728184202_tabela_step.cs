using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class tabela_step : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "STEP_ID",
                table: "COMPANY",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "STEP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    STEPS = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALUE = table.Column<int>(type: "INT", nullable: false),
                    CLOSE_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    END_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    ITENS = table.Column<int>(type: "INT", nullable: false),
                    ACTIVE = table.Column<ulong>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STEP", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_STEP_ID",
                table: "COMPANY",
                column: "STEP_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_COMPANY_STEP_STEP_ID",
                table: "COMPANY",
                column: "STEP_ID",
                principalTable: "STEP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMPANY_STEP_STEP_ID",
                table: "COMPANY");

            migrationBuilder.DropTable(
                name: "STEP");

            migrationBuilder.DropIndex(
                name: "IX_COMPANY_STEP_ID",
                table: "COMPANY");

            migrationBuilder.DropColumn(
                name: "STEP_ID",
                table: "COMPANY");
        }
    }
}
