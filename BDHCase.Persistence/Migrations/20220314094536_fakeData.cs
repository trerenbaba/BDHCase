using Microsoft.EntityFrameworkCore.Migrations;

namespace BDHCase.Persistence.Migrations
{
    public partial class fakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "0fb379f2-0f22-42e2-ae2e-082413d0d2db");

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "205c2931-ee84-414c-bbdd-4fa8e7af1f79");

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "cd520a02-a576-46e3-ad48-68b3fc73c76c");

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "0e6ba92b-f687-4f4d-9ec1-cebaf332738a", "Eren", 1, 0, 0, 0f, 7500f, "Baba", "1234567890", 0f });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "5f5e5f30-987a-4571-ab45-940f6cc04500", "Gunluk", 2, 5, 0, 0f, 0f, "Ucretli", "9876543210", 200f });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "98016e58-e2aa-499f-ae79-53e4a614f4b4", "Mesai", 3, 0, 5, 50f, 7500f, "Ucretli", "7894561230", 0f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "0e6ba92b-f687-4f4d-9ec1-cebaf332738a");

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "5f5e5f30-987a-4571-ab45-940f6cc04500");

            migrationBuilder.DeleteData(
                table: "Calisanlar",
                keyColumn: "Id",
                keyValue: "98016e58-e2aa-499f-ae79-53e4a614f4b4");

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "205c2931-ee84-414c-bbdd-4fa8e7af1f79", "Eren", 1, 0, 0, 0f, 7500f, "Baba", "1234567890", 0f });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "cd520a02-a576-46e3-ad48-68b3fc73c76c", "Gunluk", 2, 5, 0, 0f, 0f, "Ucretli", "9876543210", 200f });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "CalismaTipi", "GunlukMesai", "SaatlikMesai", "SaatlikMesaiUcreti", "SabitUcret", "Soyad", "TC", "gunlukMesaiUcreti" },
                values: new object[] { "0fb379f2-0f22-42e2-ae2e-082413d0d2db", "Mesai", 3, 5, 0, 0f, 0f, "Ucretli", "7894561230", 200f });
        }
    }
}
