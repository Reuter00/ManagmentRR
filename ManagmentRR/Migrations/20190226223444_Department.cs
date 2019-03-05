using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagmentRR.Migrations
{
    public partial class Department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tape_Empresas_EmpresaId",
                table: "Tape");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Tape",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tape_Empresas_EmpresaId",
                table: "Tape",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tape_Empresas_EmpresaId",
                table: "Tape");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "Tape",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Tape_Empresas_EmpresaId",
                table: "Tape",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
