using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LGPD_MDE.Migrations
{
    public partial class renomeartabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENTERPRISE");

            migrationBuilder.DropTable(
                name: "ENTERPRISE_CATEGORY");

            migrationBuilder.CreateTable(
                name: "COMPANY_CATEGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CATEGORY = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY_CATEGORY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QUESTION_ID = table.Column<int>(type: "INT", nullable: false),
                    FIELD_ID = table.Column<int>(type: "INT", nullable: false),
                    COMPANY_CATEGORY_ID = table.Column<int>(type: "INT", nullable: false),
                    REPORT_PERIOD_ID = table.Column<int>(type: "INT", nullable: false),
                    WORKSHOP_ID = table.Column<int>(type: "INT", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NAME = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MOBILE = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SITE = table.Column<string>(type: "VARCHAR(100)", nullable: false)
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
                    table.PrimaryKey("PK_COMPANY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMPANY_COMPANY_CATEGORY_COMPANY_CATEGORY_ID",
                        column: x => x.COMPANY_CATEGORY_ID,
                        principalTable: "COMPANY_CATEGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPANY_FIELD_FIELD_ID",
                        column: x => x.FIELD_ID,
                        principalTable: "FIELD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPANY_QUESTION_QUESTION_ID",
                        column: x => x.QUESTION_ID,
                        principalTable: "QUESTION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPANY_REPORT_PERIOD_REPORT_PERIOD_ID",
                        column: x => x.REPORT_PERIOD_ID,
                        principalTable: "REPORT_PERIOD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMPANY_WORKSHOP_WORKSHOP_ID",
                        column: x => x.WORKSHOP_ID,
                        principalTable: "WORKSHOP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_COMPANY_CATEGORY_ID",
                table: "COMPANY",
                column: "COMPANY_CATEGORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_FIELD_ID",
                table: "COMPANY",
                column: "FIELD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_QUESTION_ID",
                table: "COMPANY",
                column: "QUESTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_REPORT_PERIOD_ID",
                table: "COMPANY",
                column: "REPORT_PERIOD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_WORKSHOP_ID",
                table: "COMPANY",
                column: "WORKSHOP_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMPANY");

            migrationBuilder.DropTable(
                name: "COMPANY_CATEGORY");

            migrationBuilder.CreateTable(
                name: "ENTERPRISE_CATEGORY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CATEGORY = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENTERPRISE_CATEGORY", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENTERPRISE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ENTERPRISE_CATEGORY_ID = table.Column<int>(type: "INT", nullable: false),
                    FIELD_ID = table.Column<int>(type: "INT", nullable: false),
                    QUESTION_ID = table.Column<int>(type: "INT", nullable: false),
                    REPORT_PERIOD_ID = table.Column<int>(type: "INT", nullable: false),
                    WORKSHOP_ID = table.Column<int>(type: "INT", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMAIL = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MATURITY = table.Column<float>(type: "FLOAT", nullable: false),
                    MATURITY_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    MOBILE = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NAME = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PROGRECTION_START_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    PROGRECTION_STATUS = table.Column<ulong>(type: "BIT", nullable: false),
                    PROGRESS = table.Column<float>(type: "FLOAT", nullable: false),
                    REGISTRATION_DATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    SITE = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
        }
    }
}
