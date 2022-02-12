using System;

namespace namespace switchCase

{
    class Program
    {

        static void Main(string[] args)
        {
            
            int month=DateTime.Now.Month;
            

            //Expression
            switch(month)
        {
            case 1:
                Console.WriteLine("Ocak Ayındasın!");
                break;
            case 2:
                Console.WriteLine("Şubat Ayındasın!");
                break;
            case 4:
                Console.WriteLine("Nisan Ayındasın!");
                break;
            case 3:
                Console.WriteLine("Mart Ayındasın!");
                break;
            default:
                Console.WriteLine("Yanlış Ay girdiniz!");
                break;
        }

        switch(month)
        {
            case 12:
            case 1:
            case 2:
            Console.WriteLine("Kış!");
            break;

            case 3:
            case 4:
            case 5:
            Console.WriteLine("İlkbahar!");
            break;

            case 6:
            case 7:
            case 8:
            Console.WriteLine("Yaz!");
            break;

            case 9:
            case 10:
            case 11:
            Console.WriteLine("Sonbahar!");
            break;

            default:
                break;
        }


        }
    }
}
