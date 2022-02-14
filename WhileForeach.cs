using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak consoldan alınan sayı dahil ortalama hesaplama
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;

            while (sayac<=sayi)
            {

                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a dan zye kadar tüm harflri yazdırma

            char character='a';
            
            while (character<'z')
            {
                Console.Write(character+" ");
                character++;
            }

            //FORAECH
            string[] arabalar= {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
