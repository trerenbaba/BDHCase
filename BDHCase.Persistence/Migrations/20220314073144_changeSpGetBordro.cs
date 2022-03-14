using Microsoft.EntityFrameworkCore.Migrations;

namespace BDHCase.Persistence.Migrations
{
    public partial class changeSpGetBordro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"ALTER PROCEDURE [dbo].[GetBordro]
                    @TcNo varchar(11)
                AS
                BEGIN
                    
                    declare @calismaTipi Int
					 set @calismaTipi  =(select CalismaTipi from Calisanlar where TC=@TcNo)

					if @calismaTipi=1
						begin
							 select Id,Ad,Soyad,TC,(SabitUcret * 1) as Maas from Calisanlar where TC=@TcNo
						end
					else if @calismaTipi=2
						begin
							 select Id,Ad,Soyad,TC,(GunlukMesai*GunlukMesaiUcreti) as Maas from Calisanlar where TC=@TcNo
						end

					else
							begin
								 select Id,Ad,Soyad,TC,(SabitUcret+(SaatlikMesai*SaatlikMesaiUcreti)) as maas from Calisanlar where TC=@TcNo
							end

					END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
