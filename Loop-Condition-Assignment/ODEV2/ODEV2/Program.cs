// See https://aka.ms/new-console-template for more information
Console.Write("Arabanin yasini giriniz: ");
int araba_yasi = Convert.ToInt32(Console.ReadLine());
if(araba_yasi>=0 && araba_yasi<10)
{
    Console.WriteLine("Arabaniz yeni.");
}
else if(araba_yasi>=10 && araba_yasi < 20)
{
    Console.WriteLine("Servise goturmeniz gerekebilir.");
}
else if(araba_yasi>=20 && araba_yasi<30)
{
    Console.WriteLine("Arabaniz hurdaya cikabilir.");
}
else
{
    Console.WriteLine("Ya hic uretilmedi ya da trafikten men edilmistir.");
}

    
    
    