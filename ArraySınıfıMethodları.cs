using System;

namespace ArraySınıfıMethodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi={23,12,4,86,72,3,11,17};

            Console.WriteLine("+++++++++++Sırasız liste++++++++++++"); 
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+" ");            
            }

            Console.WriteLine("+++++++++++Sıralı liste++++++++++++"); 
            Array.Sort(sayiDizisi);
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+" ");            
            }

            //Clear
            Console.WriteLine("+++++++++++ Array Clear ++++++++++++");
            Array.Clear(sayiDizisi,2,2);
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+" ");            
            }

            Console.WriteLine("+++++++++++ Array Reverse ++++++++++++");
            //Reverse
            Array.Reverse(sayiDizisi);
             foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+" ");            
            }

            //IndexOf
            Console.WriteLine("+++++++++++ Array IndexOf ++++++++++++");
            Console.WriteLine( Array.IndexOf(sayiDizisi,23));
           
           //Resize
           Console.WriteLine("+++++++++++ Array Resize ++++++++++++");
           Array.Resize<int>(ref sayiDizisi,9);
           sayiDizisi[8]=99;
              foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi+" ");            
            }


        }
    }
}
