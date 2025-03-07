// See https://aka.ms/new-console-template for more information
using ODEV3.Classes;

BMW bmw = new BMW();
Mercedes m = new Mercedes();
Porsche por = new Porsche();
double totalFuel = bmw.fuel() + m.fuel() + por.fuel();
Console.WriteLine("Total Fuel is " + totalFuel);
