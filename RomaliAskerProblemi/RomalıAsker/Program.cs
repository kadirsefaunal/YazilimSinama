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
            int kSayisi = 0, aSayisi = 0;

            Console.Write("Kişi sayısını girin: ");
            string kisiSayisi = Console.ReadLine();
            if (SayiMi.Kontrol(kisiSayisi))
            {
                kSayisi = Convert.ToInt32(kisiSayisi);

                Console.Write("Adım sayısını girin: ");
                string adimSayisi = Console.ReadLine();
                if (SayiMi.Kontrol(adimSayisi))
                {
                    aSayisi = Convert.ToInt32(adimSayisi);
                    if (kSayisi > 2 && aSayisi > 0)
                    {
                        int[] kisiler = new int[kSayisi];
                        for (int i = 0; i < kSayisi; i++)
                            kisiler[i] = 1;

                        int oluSayisi = 0, j = -1, k = 0;
                        while (oluSayisi != (kSayisi - 2))
                        {
                            while (k != aSayisi)
                            {
                                j++;
                                if (j == kSayisi)
                                    j = 0;
                                if (kisiler[j] == 1)
                                    k++;
                            }
                            kisiler[j] = 0;
                            oluSayisi++;
                            k = 0;
                            for (int i = 0; i < kSayisi; i++)
                            {
                                Console.Write(kisiler[i] + "   ");
                            }
                            Console.WriteLine();
                        }

                        for (int i = 0; i < kSayisi; i++)
                        {
                            if (kisiler[i] == 1)
                                Console.WriteLine(i + 1);
                        }
                    }
                    else
                        Console.WriteLine("Kişi sayısı 2'den fazla olmalı yada adım sayısı 0'dan fazla olmalı!");
                }
                else
                    Console.WriteLine("Adim sayısı hatalı!");
            }
            else
                Console.WriteLine("Kisi sayısı hatalı!");
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
