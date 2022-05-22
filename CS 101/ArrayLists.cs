using System;
using System.Collections;

namespace ArrayLists // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List");
            ArrayList liste = new ArrayList();//farklı türlerden array listesi
            ArrayList liste2 = new ArrayList();
            liste.Add("Ceyda");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange birden fazla elemanı ekleme
            Console.WriteLine("AddRange");
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);
            liste2.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //sort
            System.Console.WriteLine("*******Sort*******");
            // liste.Sort();//compile zamanda hata vermedi fakat runtime zamanında hata verdi.
            /*
            sort ile aynı tipteki elemanlar sıralanabilir  arraylist içinde hem int hem string vs varsa hata verir karşılaştıramıyorum diye 
            */
            liste2.Sort();
            foreach (var item in liste2)
                System.Console.WriteLine(item);

            //Binary Search, sıralı bir liste üzerinden çalıştırılır
            System.Console.WriteLine("*******Binary Search*******");
            System.Console.WriteLine(liste2.BinarySearch(9));
            //System.Console.WriteLine(liste.BinarySearch(9)); hata veriyor
            System.Console.WriteLine("reverse");
            liste2.Reverse();
            foreach (var item in liste2)
                System.Console.WriteLine(item);

            liste.Clear();
            foreach (var item in liste)
                System.Console.WriteLine(item);
        }
    }
}