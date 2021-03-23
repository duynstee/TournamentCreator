using Microsoft.EntityFrameworkCore.Migrations;

namespace CreaterTournament.Migrations
{
    public partial class AddIPINToPlayerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IPIN",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPIN",
                table: "Player");
        }
    }
}
