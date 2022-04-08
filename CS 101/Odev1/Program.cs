using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, sayi;
            List<int> sayilar = new List<int>();

            //Soru 1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //-------------------------------------------------------------------
            Console.WriteLine("\nSORU 1");
            Console.Write("Lütfen pozitif bir n sayısı giriniz:");
             n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nLütfen girmiş olduğunuz n sayısı kadar pozitif sayı giriniz:");
            for (int i = 0; i < n; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    sayilar.Add(sayi);
                }
            }
            Console.WriteLine("Girmiş olduğunuz değerlerden çift olan sayılar:");
            foreach(int sayi_ in sayilar)
            {
                Console.Write(sayi_ + " - ");
            }

            //Soru 2- Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //--------------------------------------------------------------------
            Console.WriteLine("\nSORU 2");
            Console.WriteLine("\nLütfen pozitif iki sayı giriniz (n ve m):");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            sayilar.Clear();
            Console.WriteLine("\nLütfen girmiş olduğunuz n sayısı kadar pozitif sayısı giriniz:");
            for (int i = 0; i < n; i++)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % m == 0 | sayi==m)
                {
                    sayilar.Add(sayi);
                }
            }

            Console.WriteLine("Girmiş olduğunuz değerlerden m'e eşit veya m'e tam bölünen sayılar:(m="+m+")");
            foreach (int sayi_ in sayilar)
            {
                Console.Write(sayi_ + " - ");
            }

            //soru3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //----------------------------------------------------------------------
            Console.WriteLine("\nSORU 3");
            Console.Write("\nLütfen pozitif bir n sayısı giriniz:");
            n = Convert.ToInt32(Console.ReadLine());
            List<string> kelimeler = new List<string>();
            string kelime;
            Console.WriteLine("\nLütfen girmiş olduğunuz n sayısı kadar kelime giriniz:");
            for (int i = 0; i < n; i++)
            {
                kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }
            Console.WriteLine("Girmiş olduğunuz kelimeler:");
            foreach(string kel in kelimeler)
            {
                Console.Write(kel+" - ");
            }
            //soru 4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("\nSORU 4");
            Console.WriteLine("\nLütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string[] kelimeler2 = cumle.Split(" ");
            Console.WriteLine("Toplam kelime sayısı:" + kelimeler2.Length);
            cumle = cumle.Replace(" ", "");
            char[] harfler = cumle.ToCharArray();
            Console.WriteLine("Toplam harf sayısı:" + harfler.Length);
        }

    }
   
   
}

