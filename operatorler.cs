using System;

namespace console
{
    class Program
    {
        public static void Main(string[] args)
        {
            //atama ve işlemli atama
            Console.WriteLine("*******atama ve işlemli atama********");

            
            int x=3;
            int y=3;
            y=y+2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            // ||,&&,! 
            Console.WriteLine("*******Mantıksal Operatörler********");

            bool isSuccses = true;
            bool isCompleted= false;

            if(isSuccses && isCompleted){ //ve

                Console.WriteLine("Perfect!");
            }

             if(isSuccses || isCompleted){ //veya

                Console.WriteLine("Great!");
            }

             if(isSuccses &&! isCompleted){ //veya değilse

                Console.WriteLine("Fine!");
            }

            //ilişkisel operatörler
            // <,>,<=,>=,==,!=

            Console.WriteLine("*******İlişkisel Operatörler********");

            int a=3;
            int b=4;

            bool sonuc=a<b;
            Console.WriteLine(sonuc);

            sonuc=a>b;
            Console.WriteLine(sonuc);

            sonuc=a>=b;
            Console.WriteLine(sonuc);

            sonuc=a<=b;
            Console.WriteLine(sonuc);

            sonuc=a==b;
            Console.WriteLine(sonuc);

            sonuc=a!=b;
            Console.WriteLine(sonuc);


             //aritmatik operatörler
            // /,*,+,- %(mod almak için)

            Console.WriteLine("*******Aritmatik Operatörler********");

            int sayi1=10;
            int sayi2=5;

            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1=sayi1++;
            Console.WriteLine(sayi1);

            int sonuc2=20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
