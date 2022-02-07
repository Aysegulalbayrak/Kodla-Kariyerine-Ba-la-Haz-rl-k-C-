using System;

namespace degiskenler
{
    class Program
    {

        static void Main(string[] args)
        {
            
            byte b=5; //1byte
            sbyte c=5; //1byte

            short s=5;    //2byte
            ushort us=5; //2byte

            Int16 i16=2; //2byte
            int i=2;     //4byte
            Int32 i32=2; //4byte
            Int64 i64=2; //8byte
            uint ui=2;   //4byte

            long l=4;    //8byte
            ulong ul=4;  //8byte

            //reel sayılar
            float f=5;  //4byte
            double d=5; //8byte
            decimal de=5;//16byte

            char ch='A'; //2byte
            String str="Aysegul"; //sınırsız

            bool bl1 =true;
            bool bl =false;

            DateTime dt =DateTime.Now;

            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=4.3;

            //String ifade
            
            string str1=string.Empty;
            str1="Aysegul Albayrak";
            string ad="Aysegul";
            string soyad="Albayrak";
            string tamAd=ad+" "+soyad;

            //int tanımlama tipleri

            int int1=5;
            int int2=3;
            int int3=int1*int2;

            //boolean
            bool b1=10<2;
            Console.WriteLine(b1);

            //Degisken dön.
            string str20="20";
            int int20 =20;
            
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21= int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22= int20+int.Parse(str20);

            //Datetime

            string datetime= DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2= DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            string hour= DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

        }
    

    }
}

