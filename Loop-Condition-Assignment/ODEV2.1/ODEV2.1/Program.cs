// See https://aka.ms/new-console-template for more information
string ArabaYasDurumu(int yas)
{
    return yas switch
    {
        >= 0 and < 10 => "Arabanız yeni",
        >= 10 and < 20 => "Servise götürmeniz gerekebilir",
        >= 20 and < 30 => "Arabanız hurdaya çıkabilir",
        _ => "Ya hiç üretilmedi ya da trafikten men edilmiştir"
    };
}

Console.Write("Arabanın yaşını giriniz: ");
if (int.TryParse(Console.ReadLine(), out int yas))
{
    Console.WriteLine(ArabaYasDurumu(yas));
}
else
{
    Console.WriteLine("Geçerli bir yaş giriniz!");
}

