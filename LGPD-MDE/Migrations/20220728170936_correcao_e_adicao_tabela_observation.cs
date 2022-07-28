using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class correcao_e_adicao_tabela_observation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OBSERVATION_ID",
                table: "QUESTION",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RISK_ID",
                table: "QUESTION",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OBSERVATION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OBSERVATIONS = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OBSERVATION", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_OBSERVATION_ID",
                table: "QUESTION",
                column: "OBSERVATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_RISK_ID",
                table: "QUESTION",
                column: "RISK_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_QUESTION_OBSERVATION_OBSERVATION_ID",
                table: "QUESTION",
                column: "OBSERVATION_ID",
                principalTable: "OBSERVATION",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QUESTION_RISK_RISK_ID",
                table: "QUESTION",
                column: "RISK_ID",
                principalTable: "RISK",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QUESTION_OBSERVATION_OBSERVATION_ID",
                table: "QUESTION");

            migrationBuilder.DropForeignKey(
                name: "FK_QUESTION_RISK_RISK_ID",
                table: "QUESTION");

            migrationBuilder.DropTable(
                name: "OBSERVATION");

            migrationBuilder.DropIndex(
                name: "IX_QUESTION_OBSERVATION_ID",
                table: "QUESTION");

            migrationBuilder.DropIndex(
                name: "IX_QUESTION_RISK_ID",
                table: "QUESTION");

            migrationBuilder.DropColumn(
                name: "OBSERVATION_ID",
                table: "QUESTION");

            migrationBuilder.DropColumn(
                name: "RISK_ID",
                table: "QUESTION");
        }
    }
}
