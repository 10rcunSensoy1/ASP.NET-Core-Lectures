using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciCV.Classes
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad boş olamaz!")]
        public string Ad {  get; set; }

        [ZorunluAlan("Soyad boş olamaz!")]
        public string Soyad { get; set; }

        [ZorunluAlan("Bölüm boş olamaz!")]
        public string Bolum { get; set; }
    }
}
