using System;

namespace HataliAltin
{
    class Terazi
    {
        private int indis { get; set; }
        private int adimSayisi { get; set; }

        public void Hesapla(int[] dizi, int altinSayisi)
        {
            Hesapla(dizi, 0, altinSayisi);
        }

        private void Hesapla(int[] dizi, int baslangic, int bitis)
        {
            adimSayisi++;
            int solToplam = 0, sagToplam = 0;
            int x = 0;

            if ((bitis - baslangic) % 2 == 0)
            {
                x = (bitis - baslangic) / 2;
            }
            else
            {
                x = (bitis - 1 - baslangic) / 2;
                indis = bitis;
                bitis--;
            }

            for (int i = baslangic; i < (baslangic + x); i++)
                solToplam += dizi[i];
            for (int i = (baslangic + x); i < bitis; i++)
                sagToplam += dizi[i];

            if (solToplam > sagToplam)
                Hesapla(dizi, (baslangic + x), bitis);
            else if (solToplam < sagToplam)
                Hesapla(dizi, baslangic, (baslangic + x));
            else
            {
                Console.WriteLine("Hatalı altın: " + indis);
                Console.WriteLine("Tartılma sayısı: " + adimSayisi);
            }
                
        }
    }
}
