using Microsoft.EntityFrameworkCore.Migrations;

namespace BDHCase.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SabitUcret = table.Column<float>(type: "real", nullable: false),
                    GunlukMesai = table.Column<int>(type: "int", nullable: false),
                    gunlukMesaiUcreti = table.Column<float>(type: "real", nullable: false),
                    SaatlikMesai = table.Column<int>(type: "int", nullable: false),
                    SaatlikMesaiUcreti = table.Column<float>(type: "real", nullable: false),
                    Maas = table.Column<float>(type: "real", nullable: false),
                    CalismaTipi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisanlar");
        }
    }
}
