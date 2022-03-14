using BDHCase.Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDHCase.Persistence.Context
{

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=BDHCaseDb;Trusted_Connection=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Calisan> Calisanlar { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }


        public DbSet<CalisanView> Calisan { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CalisanView>().HasNoKey().ToView("GetBordro");
            modelBuilder.Entity<Calisan>()
                .HasData(
                    new Calisan
                    {
                        
                        Ad = "Eren",
                        Soyad = "Baba",
                        TC = "1234567890",
                        GunlukMesai = 0,
                        gunlukMesaiUcreti = 0,
                        SabitUcret = 7500,
                        SaatlikMesai = 0,
                        SaatlikMesaiUcreti = 0,
                        CalismaTipi = CalismaTipi.SabitUcretli
                    },
                    new Calisan
                    {
                        Ad = "Gunluk",
                        Soyad = "Ucretli",
                        TC = "9876543210",
                        GunlukMesai = 5,
                        gunlukMesaiUcreti = 200,
                        SabitUcret = 0,
                        SaatlikMesai = 0,
                        SaatlikMesaiUcreti = 0,
                        CalismaTipi = CalismaTipi.GunlukUcretli
                    },
                    new Calisan
                    {
                        Ad = "Mesai",
                        Soyad = "Ucretli",
                        TC = "7894561230",
                        GunlukMesai = 0,
                        gunlukMesaiUcreti = 0,
                        SabitUcret = 7500,
                        SaatlikMesai = 5,
                        SaatlikMesaiUcreti = 50,
                        CalismaTipi = CalismaTipi.MesaiUcretli
                    }
                );
        }
    }
}
