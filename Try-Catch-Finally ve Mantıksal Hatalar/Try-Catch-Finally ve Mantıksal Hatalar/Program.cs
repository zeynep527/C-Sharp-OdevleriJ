using System;

namespace Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   HATA YÖNETİMLERİ
                Try-Catch-Finally
            Try
            {
            İşlemler
            }
            Catch
            {
            Hata
            }
            Finally
            {
            Çalıştır
            }

             */


            try
            {

                int sayi1, sayi2, sonuc;
                Console.WriteLine("Sayı1: ");
                sayi1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Sayı2: ");
                sayi2 = Convert.ToInt16(Console.ReadLine());
                sonuc = sayi1 * sayi2;
                Console.WriteLine("İşlem Sonucu: " + sonuc);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata var lütfen formatınızı kontrol ediniz");
                Console.WriteLine(ex);

            }

            /* Özel Durum Formatları
             Invalid Cast Exception: Tür dönüştürme işlemlerinde kullanılır.
             Index Out Of Range Exception: Dizide bulunmayan değerlerle karşılaşınca ortaya çıkar.
             Divided By Zero: Sıfıra bölme yapılmak istendiği zaman ortaya çıkmaktadır.
             Format Exception:Sayısal bir alana sayısal olmayan bir değer girilmediğinde ortaya çıkar.
             Over Flow Exception: Bir değişkenin aralıklarının dışına çıkılması durumunda ortaya çıkar.
             Argument Null Exception: Aritmetik bir alanın boş bırakılması durumunda ortaya çıkar.
             Aritmethic Exception: Matematiksel alanlarda oluşan hata mesajıdır.



             
             
             
             */











        }
    }
}
