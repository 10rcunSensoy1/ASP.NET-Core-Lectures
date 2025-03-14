// See https://aka.ms/new-console-template for more information
using ODEV4.Company;
using System.Reflection;
using System.Reflection.Metadata;

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();
double totalSalary = gm.maasinizNedir() + mu.maasinizNedir() + pr.maasinizNedir() + s.maasinizNedir();
Console.WriteLine("Total Salary: " + totalSalary);
string[] Sirket = { gm.ID(), mu.ID(), pr.ID(), s.ID() };
for (int i=0; i < Sirket.Length; i++)
{
    Console.WriteLine(Sirket[i]);
}
