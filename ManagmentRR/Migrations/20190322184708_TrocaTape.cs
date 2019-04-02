using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagmentRR.Migrations
{
    public partial class TrocaTape : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrocaTape",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TapeId = table.Column<int>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrocaTape", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrocaTape_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrocaTape_Tape_TapeId",
                        column: x => x.TapeId,
                        principalTable: "Tape",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrocaTape_EmpresaId",
                table: "TrocaTape",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_TrocaTape_TapeId",
                table: "TrocaTape",
                column: "TapeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrocaTape");
        }
    }
}
