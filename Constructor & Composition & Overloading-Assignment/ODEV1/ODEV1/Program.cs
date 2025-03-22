// See https://aka.ms/new-console-template for more information
using ODEV1.Car;
Kapi kapı = new Kapi { KapiSayisi = 4 };
Pencere pencere = new Pencere { PencereSayisi = 4 };
Kasa kasa = new Kasa { Turu = "sedan" };
Marka marka = new Marka { Adi = "BMW", Modeli = "X5" };
decimal fiyat = 2000000;

Araba araba = new Araba(kapı, pencere, kasa, marka, fiyat);
araba.BilgiYazdır();

