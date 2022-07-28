using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class atualizando_usuario_tabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AREA_ID",
                table: "USUARIO",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "COMPANY_ID",
                table: "USUARIO",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OAB",
                table: "USUARIO",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_AREA_ID",
                table: "USUARIO",
                column: "AREA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_COMPANY_ID",
                table: "USUARIO",
                column: "COMPANY_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIO_AREA_AREA_ID",
                table: "USUARIO",
                column: "AREA_ID",
                principalTable: "AREA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_USUARIO_COMPANY_COMPANY_ID",
                table: "USUARIO",
                column: "COMPANY_ID",
                principalTable: "COMPANY",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USUARIO_AREA_AREA_ID",
                table: "USUARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_USUARIO_COMPANY_COMPANY_ID",
                table: "USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_USUARIO_AREA_ID",
                table: "USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_USUARIO_COMPANY_ID",
                table: "USUARIO");

            migrationBuilder.DropColumn(
                name: "AREA_ID",
                table: "USUARIO");

            migrationBuilder.DropColumn(
                name: "COMPANY_ID",
                table: "USUARIO");

            migrationBuilder.DropColumn(
                name: "OAB",
                table: "USUARIO");
        }
    }
}
