// See https://aka.ms/new-console-template for more information
using ODEV5.Cars;
using System.Net.Http.Headers;

BMW bmw = new BMW();
Mercedes me = new Mercedes();
Audi au = new Audi();
Ferrari fe = new Ferrari();
double totalOil = bmw.yakitTuketimi() + me.yakitTuketimi() + au.yakitTuketimi() + fe.yakitTuketimi();
Console.WriteLine("Toplam yakit tuketimi miktari: " + totalOil);