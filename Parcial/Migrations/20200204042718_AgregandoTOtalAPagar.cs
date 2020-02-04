using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial.Migrations
{
    public partial class AgregandoTOtalAPagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalAPagar",
                table: "Prestamos",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAPagar",
                table: "Prestamos");
        }
    }
}
