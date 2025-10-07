using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if ... else

            //Console.Write("Lütfen Şifrenizi Giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Hoşgeldiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Şifre Girdiniz!");

            //string gk1 , gk2 ;
            //Console.Write("1. Gizli Kelimeyi Giriniz: ");
            //gk1= Console.ReadLine();
            //Console.Write("2. Gizli Kelimeyi Giriniz: ");
            //gk2 = Console.ReadLine();

            //if (gk1 == "ayşe" && gk2 == "tatile çıksın")
            //{

            //    Console.WriteLine("Doğrulama Başarılı");
            //}
            //else
            //{
            //     Console.WriteLine("Doğrulama Başarısız");
            //}


            //int sayi1 ;
            //Console.Write("Lütfen Bir Sayı Tahmin Ediniz. (0-10 Aralığında ): ");
            //sayi1=int.Parse(Console.ReadLine());

            //if (sayi1==5)
            //{
            //    Console.WriteLine("Tahmininiz Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Tahmininiz Yanlış");
            //}
            //if (0<sayi1 && sayi1<4)
            //{
            //    Console.WriteLine("Tahmininiz Çok Düşük");
            //}
            //if (5<sayi1 && sayi1<10)
            //{
            //    Console.WriteLine("Tahmininiz Çok Yüksek");
            //}


            //double exam1, exam2, ort;
            //string sonuc;
            //Console.Write("1. Sınav Notunuzu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunuzu Giriniz: ");
            //exam2=double.Parse(Console.ReadLine());
            //ort = (exam1 * 0.4 )+(exam2 * 0.6) ;
            //if (ort >= 50)
            //{
            //    sonuc = "Geçti";
            //}
            //else
            //{
            //    sonuc = "Kaldı";
            //}
            //Console.WriteLine("Ortalamanız: " + ort + " Sonuç: " + sonuc);



            //string city;
            //Console.Write("Lütfen Şehir İsmi Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "Ankara" | city == "İstanbul" | city == "İzmir")
            //{
            //    Console.WriteLine("Yaşadığınız Şehir Türkiye'nin En Büyük 3 Şehrinden Biri");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşadığınız Şehir Türkiye'nin En Büyük 3 Şehrinden Biri Değil");
            //}

            #endregion

            #region mod işlemleri 

            int number;
            number = 26;
            int result = number % 5;
            Console.WriteLine(result);

            #endregion



            Console.Read();
            
        }
    }
}