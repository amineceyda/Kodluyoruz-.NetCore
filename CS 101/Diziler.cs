using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5]; //Null dizi tanımlama

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" }; //Dizinin elemanlarını önceden veriyorsan boyut tanımına gerek yok

            int[] dizi;
            dizi = new int[5]; //null dizilerde boyut tanımı zorunlu

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program.
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);

        }
    }
}
