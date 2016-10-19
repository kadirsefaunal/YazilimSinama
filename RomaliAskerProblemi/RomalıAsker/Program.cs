using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomalıAsker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kişi sayısını girin: ");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adım sayısını girin: ");
            int adinSayisi = Convert.ToInt32(Console.ReadLine());
            int[] kisiler = new int[kisiSayisi];
            for (int i = 0; i < kisiSayisi; i++)
            {
                kisiler[i] = 1;
            }

            int oluSayisi = 0, j = -1, k = 0;
            while (oluSayisi != (kisiSayisi - 2))
            {
                while (k != adinSayisi)
                {
                    j++;
                    if (j == kisiSayisi)
                        j = 0;
                    if (kisiler[j] == 1)
                        k++;
                }
                kisiler[j] = 0;
                oluSayisi++;
                k = 0;
                for (int i = 0; i < kisiSayisi; i++)
                {
                    Console.Write(kisiler[i] + " - ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < kisiSayisi; i++)
            {
                if (kisiler[i] == 1)
                    Console.WriteLine(i + 1);
            }
            Console.ReadKey();
        }
    }
}
