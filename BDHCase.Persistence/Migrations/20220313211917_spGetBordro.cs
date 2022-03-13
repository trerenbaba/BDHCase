using Microsoft.EntityFrameworkCore.Migrations;

namespace BDHCase.Persistence.Migrations
{
    public partial class spGetBordro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetBordro]
                    @TcNo varchar(11)
                AS
                BEGIN
                    
                    declare @calismaTipi Int
					 set @calismaTipi  =(select CalismaTipi from Calisanlar where TC=@TcNo)

					if @calismaTipi=1
						begin
							 select Id,Ad,Soyad,TC,SabitUcret ,GunlukMesai,gunlukMesaiUcreti,SaatlikMesai,SaatlikMesaiUcreti,CalismaTipi,Maas=SabitUcret from Calisanlar where TC=@TcNo
						end
					else if @calismaTipi=2
						begin
							 select Id,Ad,Soyad,TC,SabitUcret,GunlukMesai,gunlukMesaiUcreti,SaatlikMesai,SaatlikMesaiUcreti,CalismaTipi,Maas= (GunlukMesai*GunlukMesaiUcreti) from Calisanlar where TC=@TcNo
						end

					else
						begin
							 select Id,Ad,Soyad,TC,SabitUcret,GunlukMesai,gunlukMesaiUcreti,SaatlikMesai,SaatlikMesaiUcreti,CalismaTipi,Maas=(SabitUcret+(SaatlikMesai*SaatlikMesaiUcreti)) from Calisanlar where TC=@TcNo
						end

                END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
