using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class criar_tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AREA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AREAS = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREA", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENTERPRISE_CATEGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CATEGORY = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTERPRISE_CATEGORY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EXCEPTIONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(1100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATE = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    MESSAGE = table.Column<string>(type: "VARCHAR(500)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EXCEPTIONS", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FIELD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FIELDS = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIELD", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IMPACT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IMPACTS = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPACT", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PROBABILITY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PROBABILITYS = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROBABILITY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QUESTION_CATEGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CATEGORY = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTION_CATEGORY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "REPORT_PERIOD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PERIOD = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORT_PERIOD", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RISK",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RISKS = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RISK", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FUNCTION = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MOBILE = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    USER = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PASSWORD = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IS_ACTIVE = table.Column<ulong>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORKSHOP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MEETING_LINK = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATE = table.Column<DateTime>(type: "DATETIME", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKSHOP", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QUESTION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AREA_ID = table.Column<int>(type: "INT", nullable: false),
                    QUESTION_CATEGORY_ID = table.Column<int>(type: "INT", nullable: false),
                    IMPACT_ID = table.Column<int>(type: "INT", nullable: false),
                    PROBABILITY_ID = table.Column<int>(type: "INT", nullable: false),
                    WORDING = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    REPLY = table.Column<int>(type: "INT", nullable: false),
                    REPLIED_STATUS = table.Column<ulong>(type: "BIT", nullable: false),
                    SUITABLE_STATUS = table.Column<ulong>(type: "BIT", nullable: false),
                    EFFECT = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ACTION = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QUESTION_AREA_AREA_ID",
                        column: x => x.AREA_ID,
                        principalTable: "AREA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QUESTION_IMPACT_IMPACT_ID",
                        column: x => x.IMPACT_ID,
                        principalTable: "IMPACT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QUESTION_PROBABILITY_PROBABILITY_ID",
                        column: x => x.PROBABILITY_ID,
                        principalTable: "PROBABILITY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QUESTION_QUESTION_CATEGORY_QUESTION_CATEGORY_ID",
                        column: x => x.QUESTION_CATEGORY_ID,
                        principalTable: "QUESTION_CATEGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENTERPRISE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QUESTION_ID = table.Column<int>(type: "INT", nullable: false),
                    FIELD_ID = table.Column<int>(type: "INT", nullable: false),
                    ENTERPRISE_CATEGORY_ID = table.Column<int>(type: "INT", nullable: false),
                    REPORT_PERIOD_ID = table.Column<int>(type: "INT", nullable: false),
                    WORKSHOP_ID = table.Column<int>(type: "INT", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NAME = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MOBILE = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SITE = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PROGRESS = table.Column<float>(type: "FLOAT", nullable: false),
                    PROGRECTION_STATUS = table.Column<ulong>(type: "BIT", nullable: false),
                    PROGRECTION_START_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    MATURITY = table.Column<float>(type: "FLOAT", nullable: false),
                    REGISTRATION_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    MATURITY_DATE = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTERPRISE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ENTERPRISE_ENTERPRISE_CATEGORY_ENTERPRISE_CATEGORY_ID",
                        column: x => x.ENTERPRISE_CATEGORY_ID,
                        principalTable: "ENTERPRISE_CATEGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ENTERPRISE_FIELD_FIELD_ID",
                        column: x => x.FIELD_ID,
                        principalTable: "FIELD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ENTERPRISE_QUESTION_QUESTION_ID",
                        column: x => x.QUESTION_ID,
                        principalTable: "QUESTION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ENTERPRISE_REPORT_PERIOD_REPORT_PERIOD_ID",
                        column: x => x.REPORT_PERIOD_ID,
                        principalTable: "REPORT_PERIOD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ENTERPRISE_WORKSHOP_WORKSHOP_ID",
                        column: x => x.WORKSHOP_ID,
                        principalTable: "WORKSHOP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ENTERPRISE_ENTERPRISE_CATEGORY_ID",
                table: "ENTERPRISE",
                column: "ENTERPRISE_CATEGORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTERPRISE_FIELD_ID",
                table: "ENTERPRISE",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTERPRISE_QUESTION_ID",
                table: "ENTERPRISE",
                column: "QUESTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTERPRISE_REPORT_PERIOD_ID",
                table: "ENTERPRISE",
                column: "REPORT_PERIOD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ENTERPRISE_WORKSHOP_ID",
                table: "ENTERPRISE",
                column: "WORKSHOP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_AREA_ID",
                table: "QUESTION",
                column: "AREA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_IMPACT_ID",
                table: "QUESTION",
                column: "IMPACT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_PROBABILITY_ID",
                table: "QUESTION",
                column: "PROBABILITY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_QUESTION_QUESTION_CATEGORY_ID",
                table: "QUESTION",
                column: "QUESTION_CATEGORY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENTERPRISE");

            migrationBuilder.DropTable(
                name: "EXCEPTIONS");

            migrationBuilder.DropTable(
                name: "RISK");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "ENTERPRISE_CATEGORY");

            migrationBuilder.DropTable(
                name: "FIELD");

            migrationBuilder.DropTable(
                name: "QUESTION");

            migrationBuilder.DropTable(
                name: "REPORT_PERIOD");

            migrationBuilder.DropTable(
                name: "WORKSHOP");

            migrationBuilder.DropTable(
                name: "AREA");

            migrationBuilder.DropTable(
                name: "IMPACT");

            migrationBuilder.DropTable(
                name: "PROBABILITY");

            migrationBuilder.DropTable(
                name: "QUESTION_CATEGORY");
        }
    }
}
