using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class criando_usuario_teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DESCRICAO",
                table: "USUARIO",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRICAO",
                table: "USUARIO");
        }
    }
}
