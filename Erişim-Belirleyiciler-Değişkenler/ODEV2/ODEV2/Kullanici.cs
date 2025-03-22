using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV2
{
    class Kullanici
    {
        private string adSoyad; 
        private int yas;        
        public string Email { get; set; } 
        
        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string value)
        {
            adSoyad = value;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int value)
        {
            yas = value;
        }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}, Yaş: {yas}, Email: {Email}");
        }

    }
}
