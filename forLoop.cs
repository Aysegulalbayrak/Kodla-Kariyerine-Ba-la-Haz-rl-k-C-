using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdırma

            Console.WriteLine("Bir sayı giriniz: ");
            int sayac=int.Parse(Console.ReadLine());

            for (int i = 0; i < sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);

                }
                

            //1 ile 1000 arasındaki tek ve çift sayıların toplamını yazdırma
            
            int tekToplam=0;
            int ciftToplam=0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tekToplam+=i;
                }

                else
                {
                    ciftToplam+=i;
                }

            }

            Console.WriteLine("Tek toplam: " +tekToplam);
            Console.WriteLine("Çift toplam: " +ciftToplam);

            //Break:Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır.
            //Continue:Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu sonlandırır. Döngü bir sonraki iterasyondan devam eder.

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

                 for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
