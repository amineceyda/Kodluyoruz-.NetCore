using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);

            }
            catch (Exception ex)
            {
                //Hata ex bir obje message hata mesajı onu stringe döndürerek ekranda hatanın sebebini görebilirsin.
                Console.WriteLine("HATA:" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
                //Burası opsiyonel hata yakalansın yakalanmasın çalışır.
            }

            try
            {
                //STRİNG TO İNT (PARSE)
                //int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("-200000000000");

            }//Bu şekilde beklenen hataları alt alta yazabilirsin
            //Hangi hata meydana gelirse o blok çalışır
            catch (ArgumentNullException ex)//Spesifik bir hata bekliyorsak
            {
                Console.WriteLine("Boş değer girdiniz:");
                Console.WriteLine(ex);
                //bana hatanın hangi satırdan kaynaklandığına kadar her şeyi gösteriyor.

            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi dönüşüme uygun değil");
                Console.WriteLine(ex);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı.");
            }
            
        }
    }
}
