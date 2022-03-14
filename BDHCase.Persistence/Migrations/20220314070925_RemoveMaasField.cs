using Microsoft.EntityFrameworkCore.Migrations;

namespace BDHCase.Persistence.Migrations
{
    public partial class RemoveMaasField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maas",
                table: "Calisanlar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Maas",
                table: "Calisanlar",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
