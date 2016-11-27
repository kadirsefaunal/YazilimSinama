using System;
using System.Diagnostics;

namespace HataliAltin
{
    class Program
    {
        static void Main(string[] args)
        {
            int aSayisi = 0;
            Stopwatch sure = new Stopwatch(); //Geçen süreyi bulmak için kullanılıyor.

            Console.Write("Altın Sayısını Girin: ");
            string altinSayisi = Console.ReadLine();

            if (SayiMi.Kontrol(altinSayisi))
            {
                aSayisi = Convert.ToInt32(altinSayisi);

                int[] altinlar = new int[aSayisi];
                for (int i = 0; i < aSayisi; i++)
                    altinlar[i] = 1;

                Random rast = new Random();
                int hataliAltinIndis = rast.Next(0, aSayisi);
                altinlar[hataliAltinIndis] = 0;

                Console.WriteLine();
                foreach (int item in altinlar)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Terazi terazi = new Terazi();
                sure.Start();
                terazi.Hesapla(altinlar, aSayisi);
                sure.Stop();

                Console.WriteLine("\nÇalisma süresi: " + sure.Elapsed.TotalMilliseconds + " milisaniye\n");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Bu değer girilemez!");
            Console.ReadKey();
        }

        static class SayiMi
        {
            public static bool Kontrol(string ifade)
            {
                foreach (char chr in ifade)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
        }
    }
}
