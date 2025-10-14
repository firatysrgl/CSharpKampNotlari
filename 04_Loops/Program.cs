using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (x; y; z)
            //x: Başlangıç
            //y:bitiş 
            //z: artış- azalış 

            //int i;
            //for (i =0;i<=5;i++) 
            //{
            //    Console.WriteLine("FIRAT YUNUS");
            //}

            //for ( int i=0;i<=200000;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i =7; i<=i; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılma adedi giriniz : ");
            //int adet = int.Parse(Console.ReadLine());

            //for (int i = 1; i<=adet; i++)
            //{
            //    Console.WriteLine("FIRAT YUNUS");
            //}


            #endregion

            #region for ile kara yapıları

            //for (int i=1; i<=100;i++)
            //     if (i% 5 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //int totalValue = 0;

            //for (int i = 1;i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);



            ////int bacterium = 1;

            ////for (int i = 1; i<=24; i++)
            ////{
            ////    bacterium *= 2;
            ////    Console.WriteLine(i + ". Saatte Bakteri Sayısı : " + bacterium);
            //}




            #endregion


            #region While Döngüsü

            // While (Şart)
            // {
            //  İŞLEMLER
            // }

            //int İ = 0;

            //while (İ<10)
            //{
            //    Console.WriteLine("FIRAT YUNUS");
            //    İ++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;

            //int sum = 0;


            //while (i <=100)
            //{
            //    sum += i;
            //    i ++;
            //}
            //Console.WriteLine(sum);
            #endregion


            #region Örnek Sınav Sorusu

            //Console.Write("3 Basamaklı Bir Sayı Giriniz :");
            //int sayi = int.Parse(Console.ReadLine());

            //int hunders = sayi / 100;
            //int ones = sayi % 10;
            //int tens = sayi / 10 % 10;

            //int total = hunders + tens + ones;

            //Console.WriteLine("Basamak Toplamı : " + total);


            #endregion



            Console.Read();
        } 


    }
}

