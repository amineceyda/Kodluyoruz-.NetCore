using System;

namespace MetotTanımlama
{
    class Program
    {

        static int Topla(int deger1, int deger2)//başına static eklemezsem static mainden erişemem
        {
            return (deger1 + deger2); //Bu değerler call by value olduğu için sadece fonksiyon üzerinden erişilebilir
        }
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donuctipi metot_adliparametreListesi/arguman
            //{
            ///Komutlar;
            ///return ;
            ///}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc= Topla(a, b);//CALL BY VALUE //kopya 2 integer ile çalışıyor
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar { };//Bir classa erişmek istiyorsam önce örnek oluşturman gerek
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);//Kopyalar üzerinde değilde a ve b nin orjinal adresleri üzerinde işlem yapıyor
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            int sonuc3 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc3));


        }

        
    }
    class Metotlar
    {
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)//call by ref
        {
            deger1 += 1;
            deger2 += 1;

            return (deger1 + deger2);
        }
    }
}
