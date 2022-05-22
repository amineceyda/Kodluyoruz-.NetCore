using System;

namespace StringMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz";
            string degisken2 = "Dersimiz CSharp";

            //Length;
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //ConCat stringe bir şeyler eklemek için
            Console.WriteLine(String.Concat(degisken, "Merhaba"));

            //Compare , CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); //0 1 -1
            Console.WriteLine(String.Compare(degisken, degisken2, true));//Büyük küçük harf duyarlı mı?

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Hosgeldiniz"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CSharp"));//kelimenin ilk başladığı indexi döndürür hiç bir şey yoksa -1
            Console.WriteLine(degisken.LastIndexOf("i"));
            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba"));//0.indexe Merhaba ekler

            //PadLeft , PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));//degisken2 nin soluna 30'a tamamlayacak kadar boşluk koyar eğer eleman uzunluğun 30 dan zaten büyükse bir şey yapmaz
            Console.WriteLine(degisken + degisken2.PadRight(30,'*'));   


            //Remove

            Console.WriteLine(degisken.Remove(10));//10.indexten itibaren siler
            Console.WriteLine(degisken.Remove(5, 3));//5 ten başlayarak 3 karakter siler


            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degisken.Split(" ")[1]);//Split yeni dizi oluşturur

            //Substring
            Console.WriteLine(degisken.Substring(4));







        }
    }
}