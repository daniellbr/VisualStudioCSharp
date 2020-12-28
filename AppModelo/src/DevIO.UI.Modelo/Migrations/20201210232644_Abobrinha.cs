using Microsoft.EntityFrameworkCore.Migrations;

namespace DevIO.UI.Modelo.Migrations
{
    public partial class Abobrinha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "abobrinha",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "abobrinha",
                table: "Alunos");
        }
    }
}
