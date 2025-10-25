using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2,4,6,8,10

            // adana , ankara , istanbul , izmir

            // sarı , kırmızı , mavi 

            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü [Eleman Sayısı];

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[0]);


            //string[] cities = new string[5];

            //cities[0] = "Milona";
            //cities[1] = "Roma";
            //cities[2] = "Napoli";
            //cities[3] = "Torino";
            //cities[4] = "Venedik";

            //Console.WriteLine(cities[5]);      // !!! Hata: 5. indeks yoktur.[ Tüm indis değerleri 0'dan başlar.  ]


            //int [] numbers = new int[10];

            //numbers[0] = 2;
            //numbers[1] = 48;
            //numbers[2] = 62;
            //numbers[7] = 896;
            //numbers[9] = 1000;

            //Console.WriteLine(numbers[4]);  // !!! Hata: 4. indeks atanmamış, default değeri gösterir. [ int için default değer 0'dır. ]

            //string [] fruit = {"Elma", "Armut", "Muz", "Kivi", "Çilek" };

            //Console.WriteLine(fruit[2]);  // !!!  böyle de tanımlanabilir.




            #endregion


            #region DizidekiTüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Mavi", "Sarı", "Yeşil" , "Beyaz" ,"mor" };

            //for (int i =0; i < 6; i ++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 2, 4, 654, 25635, 658, 2365, 789, 8989, 12345, 3975, 1 };

            //for (int i = 0; i< numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    { Console.WriteLine(numbers[i]+" ---- Sayısı  3 'e Tam Bölünür "); }
            //    else
            //    {
            //        Console.WriteLine(numbers[i] + " --- Sayısı  3'e Tam Bölünmez ");
            //    }

            //}


            //char[] symbols = { '!', '*', '+', '-', '/', '@', '#', '$', '%', '^' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //     Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 232, 545, 112, 67, 354, 8900, 190, 1251, 5, 728 , 201 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i< myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine("Dizideki En Büyük Sayı : " + maxNumber);



            //string[] persons = { "Ali Veli", "Ayşe Fatma", "Ahmet Mehmet", "Zeynep Elif", "Murat Can" };
            //Console.WriteLine("Dizideki Kişi Sayısı : " + persons.Length);



            //int[] numbers = { 23, 45, 12, 67, 34, 89, 90, 11, 5, 78, 22 , 256 };
            //Array.Sort(numbers);  // !!!! Diziyi Küçükten Büyüğe Sıralar.
            //for (int i = 0; i< numbers.Length; i++ )
            //{
            // Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 23, 45, 12, 67, 34, 89, 90, 11, 5, 78, 22, 256 };
            //Array.Reverse(numbers);  // !!!! Diziyi TERSTEN Sıralar.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string [] customers = {"Ali","Veli","Ayşe","Fatma","Ahmet","Mehmet" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine("Aranan Elemanın İndex Değeri : " + index);






            #endregion


            #region Dizi Metotları


            //int [] numbers = { 23, 45, 12, 67, 34, 89, 90, 11, 5, 78, 22, 256,55,89652 };
            //Console.WriteLine("Dizinin En Büyük Elemanı : " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı : " + numbers.Min());


            #endregion


            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1} . Şehri Giriniz :  ");
            //    cities[i] = Console.ReadLine();
            //}
            //    Console.WriteLine();
            //    Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            // Console.WriteLine($"Girilen {i + 1}. Şehir : {cities[i]}");
            //}




            //int[] numbers = { 23, 45, 12, 67, 34, 89, 90, 11, 5, 78, 22, 256, 55, 89652 };
            //int total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine("Dizideki Elemanların Toplamı : " + total);






            //int[] numbers = { 23, 45, 12, 67, 34, 89, 91, 11, 5, 78, 22, 257, 55, 89652 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("--------------------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) // çift kontrolü
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("--------------------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0) // tek kontrolü - daha doğru yöntem
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion


            Console.Read();

        }
    }
}



        



       
            
        
   

