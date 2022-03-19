using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayaçtan küçük olan tek sayıları ekrana yazdır.

            Console.WriteLine("Bir sayı giriniz.");

            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {

                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
            int oddSum = 0;
            int evenSum = 0;

            for (var i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + oddSum);
            Console.WriteLine("Çift Toplam: " + evenSum);

            //break -- continue
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    break; //Döngüden çıkar
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    continue; //döngünün başına geri dönüp devam eder
                Console.WriteLine(i);
            }

            // While
            // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program

            Console.Write("Bir sayı giriniz");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            int summary = 0;
            while (counter <= number)
            {
                summary += counter;
                counter++;
            }

            Console.WriteLine(summary / number);

            //a dan z ye kadar tüm harfleri yazdıralım.
            char character = 'a';

            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

            //ForEach dizilerin listelerin kısacası iteratör kullanılan yapılarda kolaylık sağlar
            string[] cars = { "BMW", "Audi", "Mercedes", "Bentley", "McLaren" };
            foreach (var car in cars) //var tüm tipler için geçerlidir.
            {
                Console.WriteLine(car);
            }
        }
    }
}
