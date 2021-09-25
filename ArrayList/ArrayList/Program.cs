
using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Standart diziler aynı veri tipindeki elemanları içermektedir. Örneğin int tipinde oluşturduğumuz bir
            dizide sadece tam sayı tutabiliriz. Ancak ArrayList’de böyle bir kısıtlama bulunmamaktadır. Farklı veri
            tipindeki öğeleri ArrayList’e ekleyebiliriz.

            Standart diziler sabit boyutludur; programlama aşamasında dizinin boyutu belirtilir ve programın
            çalışması sırasında değiştirilemez. ArrayList ise değişken boyutludur. Eleman ekleme ve çıkarma durumuna
            göre boyutu dinamik olarak değişmektedir.  
            using.Collections kütüphanesini kullanır */

            //Listeye eleman eklemek
            ArrayList liste = new ArrayList();
            liste.Add(2);
            //liste.Add("Zeynep");
            //liste.Add(true);
            //liste.Add('K');

            //Liste içerisindeki verilere erişmek
            Console.WriteLine(liste[0]);

            //Foreach ile liste içerisindeki verilere erişmek
            foreach (var veri in liste)
                Console.WriteLine(veri);

            //AddRange: birden fazla elemanı topluca ekler
            Console.WriteLine("\nAdd Range Metodu");
            //string[] renkler = { "mor", "mavi", "beyaz" };
            List<int> sayilar = new List<int>() { 1, 45, 78, 45, 34, 8, 4 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort : sıralamak
            Console.WriteLine("\nSort Metodu");
            liste.Sort();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search : kullanmadan önce sıralamamız gerekir
            Console.WriteLine("\nBinary Search Metodu");
            Console.WriteLine(liste.BinarySearch(45));

            //Reverse : tersten sıralar
            Console.WriteLine("\nReverse Metodu");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear : kolleksiyon içindeki tüm öğeleri siler
            //liste.Clear();
            //foreach (var item in liste)
            //    Console.WriteLine(item);
        }
    }
}
