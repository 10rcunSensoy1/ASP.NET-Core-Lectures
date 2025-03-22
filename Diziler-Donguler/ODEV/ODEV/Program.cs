// See https://aka.ms/new-console-template for more information
int[] sayilar = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
    sayilar[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (int sayi in sayilar)
{
    toplam += sayi;
}

double ortalama = (double)toplam / sayilar.Length;

Console.WriteLine($"Girdiğiniz sayıların ortalaması: {ortalama}");
