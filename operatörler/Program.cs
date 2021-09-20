using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama İşlemleri
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            // ||, &&, !
            bool isSuccess = true;
            bool İsCompleted = false;

            if(isSuccess && İsCompleted)
                Console.WriteLine("Perfeect!");

            if(isSuccess || İsCompleted)
                Console.WriteLine("Great!");

            if(isSuccess&& İsCompleted)
                Console.WriteLine("Fine!");

            //İlişkisel Operatörler
            //<,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmatik Operatörler
            // /,*,+,-

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc);

            // % Mod alır.
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);


        }
    }
}
