using System;

namespace MetotOverloading
{ /*
* Metot Overloading Nedir?
Method overloading yani metotların aşırı yüklenmesi
metot imzasının değiştirilerek aynı isimdeki metodun birden
farklı versiyonun yaratılmasıdır.
Metot imzası 
metotAdı + parametresayisi + parametre tipleri
*/
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "9999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonuc);//out değişkeninin bir ilk değeri olmak zorunda değildir. 
            Console.WriteLine(toplamSonuc);


            //Metot Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Ceyda", " Tan");
        }


    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
