// See https://aka.ms/new-console-template for more information
using ODEV2.Classes;

GenelMudur gm = new GenelMudur();
Mudur m = new Mudur();
Programci pro = new Programci();
Stajyer s = new Stajyer();
double totalSalary = gm.Salary() + m.Salary() + pro.Salary() + s.Salary();
Console.WriteLine("Total Salary is " + totalSalary);


