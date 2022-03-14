using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDHCase.Domain.models
{
    public enum CalismaTipi
    {
        SabitUcretli = 1,
        GunlukUcretli = 2,
        MesaiUcretli = 3
    }
    public class Calisan:Entity
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public float SabitUcret { get; set; } //sabit ücretli çalışanın ücreti ve mesaili çalışanın sabit ücreti.
        public int GunlukMesai { get; set; } //günlük çalışanın çalışma gün sayısı
        public float gunlukMesaiUcreti { get; set; } // günlük çalışanın 1 günlük çalışma ücreti
        public int SaatlikMesai { get; set; } // mesaili çalışanın mesai saati
        public float SaatlikMesaiUcreti { get; set; } //mesaili çalışanın mesai saati ücreti


        public CalismaTipi CalismaTipi { get; set; }


        public Calisan()
        {
            Id = Guid.NewGuid().ToString();
        }

        public void SetAd(string ad)
        {
            if (string.IsNullOrEmpty(ad))
            {
                throw new Exception("İsmi boş geçilemez");
            }
            Ad = ad.Trim();
        }
        public void SetSoyad(string soyad)
        {
            if (string.IsNullOrEmpty(soyad))
            {
                throw new Exception("Soyadı boş geçilemez");
            }
            Soyad = soyad.Trim();
        }
        public void SetTc(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 11)
            {
                throw new Exception("TC kimlik numarası boş veya eksik girildi.");
            }
            TC = tc.Trim();
        }
    }
}
