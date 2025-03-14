// See https://aka.ms/new-console-template for more information

Console.Write("Yasinizi giriniz: ");
int kisinin_yasi = Convert.ToInt32(Console.ReadLine());

if(kisinin_yasi >0 && kisinin_yasi < 18 )
{
    Console.WriteLine("Kucuksunuz.");
}
else if(kisinin_yasi>=18 && kisinin_yasi<35)
{
    Console.WriteLine("Gencsiniz.");
}
else if(kisinin_yasi>=35 && kisinin_yasi<55)
{
    Console.WriteLine("Yetiskinsiniz.");
}
else if(kisinin_yasi>=55 && kisinin_yasi<75)
{
    Console.WriteLine("Yaslisiniz.");
}
else if(kisinin_yasi>=75 && kisinin_yasi<99)
{
    Console.WriteLine("Cok yaslisiniz.");
}
else if(kisinin_yasi<0 || kisinin_yasi>99)
{
    Console.WriteLine("Ya hic dogmadiniz ya da çoktan oldunuz...");
}
else if(kisinin_yasi==0)
{
    Console.WriteLine("Yeni dogmus bir bebeksiniz.");
}
else
{
    Console.WriteLine("Lutfen tam sayı bir deger giriniz..");
}