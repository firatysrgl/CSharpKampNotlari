using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            // Foreach (1 ; 2 ; 3 ; 4 ) 
            // 1 : Değişken türü 
            // 2 :Değişken adı 
            // 3 : In
            // 4 : Liste , Koleksiyon , Dizi 


            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 125, 1452, 553, 2224, 145, 16, 75555, 803, 958, 10862 };
            //foreach (int ciftsayi in numbers)
            //{
            //    if (ciftsayi % 2 == 0)
            //    {
            //        Console.WriteLine(ciftsayi);
            //    }
            //}



            //int[] numbers = { 125, 1452, 553, 2224, 145, 16, 75, 8203, 958, 10862 };
            //int total = 0;

            //foreach (int i in numbers)
            //{ total += i; }
            //Console.WriteLine("Toplam : " + total);



            //string  word = "Merhaba" ;

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}

            #endregion


            #region Örnek Sınav Uygulaması

            //Console.WriteLine("******** C# Eğitim Kampı ********");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //// Öğrenci Sayısını Kullanıcıdan Alma 

            //Console.WriteLine();
            //Console.Write("Sınıfınzda Kaç Öğrenci Var ?  : ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------");

            //// Öğrenci İsimlerini ve Notlarını Tutacak Diziler

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //Console.WriteLine();

            //for (int i = 0; i< studentCount; i++)
            //{
            //    Console.Write($" { i+1}. Öğrencinin Adını Giriniz : ");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    // Her Öğrencinin 3 Sınav Notunu Alma
            //    Console.WriteLine();

            //    for (int x=0; x < 3; x++)
            //    {
            //        Console.Write($" {studentNames[i]} Adlı Öğrencinin {x + 1}. Sınav Notunu Giriniz : ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;

            //    }

            //    studentExamAvg[i] = totalExamResult / 3;

            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($" {studentNames[i]} Adlı Öğrencinin Sınav Ortalaması : {studentExamAvg[i]} ");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($" {studentNames[i]} İsimli Öğrenci  Tebrikler Dersten Geçtiniz ! ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($" {studentNames[i]} İsimli Öğrenci  Maalesef Derseten Kaldınız ! ");
            //    }
            //    Console.WriteLine("-----------------------------------");
            //}




            #endregion

            Console.Read();
        }
    }
}
