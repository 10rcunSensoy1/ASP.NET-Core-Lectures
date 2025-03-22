// See https://aka.ms/new-console-template for more information
using ODEV2;

Matematik matematik = new Matematik();
Console.WriteLine("Toplama:");
Console.WriteLine("İki integer: (10,25) Sonucu = " + matematik.Topla(10, 25));
Console.WriteLine("Üç integer: (12,23,30) Sonucu = " + matematik.Topla(12, 23, 30));
Console.WriteLine("İki double: (11.5,15.5) Sonucu = " + matematik.Topla(11.5, 15.5));


Console.WriteLine("\nÇarpma:");
Console.WriteLine("İki integer: (2,3) Sonucu = " + matematik.Carp(2, 3));
Console.WriteLine("Üç integer: (2,3,4) Sonucu = " + matematik.Carp(2, 3, 4));
Console.WriteLine("İki double: (1.5,2.5) Sonucu = " + matematik.Carp(1.5, 2.5));

