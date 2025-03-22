using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Car
{
    public class Araba
    {
        public Kapi Kapı { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public Marka Marka { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Kapi kapı, Pencere pencere, Kasa kasa, Marka marka, decimal fiyat)
        {
            Kapı = kapı;
            Pencere = pencere;
            Kasa = kasa;
            Marka = marka;
            Fiyat = fiyat;
        }

        public void BilgiYazdır()
        {
            Console.WriteLine($"Arabanın markası {Marka.Adi}, modeli {Marka.Modeli}, kapı sayısı {Kapı.KapiSayisi}, pencere sayısı {Pencere.PencereSayisi}, kasası {Kasa.Turu}, fiyatı {Fiyat} TL'dir.");
        }

    }
}
