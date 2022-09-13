using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDonationManagementSystem.Migrations
{
    public partial class inial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donars",
                columns: table => new
                {
                    FoodParcelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(nullable: true),
                    FoddContent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donars", x => x.FoodParcelID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donars");
        }
    }
}
