using System;

namespace ArraySinifiMetodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 34, 23, 12, 67, 45, 9, 43 };

            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Sort
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("Array Clear");
            //Sayı dizisi elemanları kullanılarak 2.indexten itibaren 2 tane elemanı 0'lar
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse, dizi tersten yazdırır
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 45));

            //Resize
            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            
            

            
            
            
            
        }
    }
}
