using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void  Metotlar

            // Bir Yapıyı Metot Yapan Şey " () " dir.
            //Geriye Değer Döndürmeyen Metotlar

            //void CustomerList ()
            //{
            //    Console.WriteLine("Mehmet şükri");
            //    Console.WriteLine ("Ayşe Yılmaz");
            //    Console.WriteLine ("Fatma Demir");
            //    Console.WriteLine ("Ali Veli");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();



            //void mehmetŞükri ()
            //{
            //    Console.WriteLine("Merhaba  Mehmet Şükri");
            //}


            //mehmetŞükri();
            //mehmetŞükri();
            //mehmetŞükri();
            //mehmetŞükri();



            //void sum ()
            //                {
            //    int a = 10;
            //    int b = 20;
            //    int total = a + b;
            //    Console.WriteLine("Toplam : " + total);
            //}
            //sum();









            #endregion

            #region Geri Değer Döndürmeyen Parametreli Metotlar


            //void WriteMetod (string CustomerName)
            //{
            //    Console.WriteLine("Müşteri Adı : " + CustomerName);

            //}
            //WriteMetod("Mehmet Şükri");



            //void CustomerCard (string name, string surName)
            //                {
            //    Console.WriteLine("Müşteri Adı : " + name  + " " +surName);
            //}


            //CustomerCard("Mehmet", "Şükri");
            //CustomerCard("Ayşe", "Yılmaz");



            //void sum (int a ,int b, int c)
            //{
            //    int total = a + b + c;
            //    Console.WriteLine("Toplam : " + total);
            //}

            //sum (10, 20, 30);





            #endregion

            #region Geriye Değer DÖndüren Metotlar

            //string studentCard() 
            //{
            //    string name = "Mehmet";
            //    string surName = "Şükri";

            //    return name + " " + surName;
            //}
            // Console.WriteLine(studentCard());




            #endregion

            #region Geri Değer Döndüren Parametreli Metotlar


            //string CountryCard (string countryName, string capitalName,string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " - " + "Başkent : " + capitalName + " - " + "Bayrak Rengi : " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Lütfen Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Lütfen Başkent Adını Giriniz : ");   
            //y = Console.ReadLine();

            //Console.Write("Lütfen Bayrak Rengini Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));


            //int sum (int a, int b )
            //{
            //    int total = a + b;
            //    return total;
            //}

            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(455, 98));
            //Console.WriteLine(sum(45, 9258));
            //Console.WriteLine(sum(2365, 257));



            #endregion

            #region Örnek Uygulama 

            //string ExamResult (string studentNmae , int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //      return  studentNmae +  " Adlı Öğrenci Sınavı Geçti " + " ---> " + "Ortalaması : "+result ;
            //    }
            //    else
            //    {
            //       return studentNmae + " Adlı Öğrenci Sınavdan Kaldı " + " ---> " + "Ortalaması : " + result; 
            //    }

                

            //}
            //Console.WriteLine(ExamResult("Ali ", 25,45,98));
            //Console.WriteLine(ExamResult("Mehmet Şükri ", 45, 90, 05));

            #endregion



            Console.Read();
        }
    }
}
