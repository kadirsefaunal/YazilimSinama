using System;
using System.Diagnostics;

namespace HataliAltin
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sure = new Stopwatch(); //Geçen süreyi bulmak için kullanılıyor.

            Console.Write("Altın Sayısını Girin: ");
            int altinSayisi = Convert.ToInt32(Console.ReadLine());

            int[] altinlar = new int[altinSayisi];
            for (int i = 0; i < altinSayisi; i++)
                altinlar[i] = 1;

            Random rast = new Random();
            int hataliAltinIndis = rast.Next(0, altinSayisi);
            altinlar[hataliAltinIndis] = 0;

            Console.WriteLine();
            foreach (int item in altinlar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Terazi terazi = new Terazi();
            sure.Start();
            terazi.Hesapla(altinlar, altinSayisi);
            sure.Stop();

            Console.WriteLine("\nÇalisma süresi: " + sure.Elapsed.TotalMilliseconds + " milisaniye\n");
            Console.ReadKey();
        }
    }
}
