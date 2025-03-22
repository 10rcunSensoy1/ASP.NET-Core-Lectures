namespace ProgramTest
{
    using MatematikIslemleri;

    class Program
    {
        static void Main(string[] args)
        {
            
            Hesaplama hesaplama = new Hesaplama();

            
            int toplam = hesaplama.Topla(87, 41);
            int carpim = hesaplama.Carp(52, 4);

            
            Console.WriteLine($"Toplama Sonucu: {toplam}");
            Console.WriteLine($"Çarpma Sonucu: {carpim}");
        }
    }
}
