using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
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

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine ());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //if (result == 0)
            //{
            //    Console.WriteLine("Bölme İşlemi Tam Bölünür");
            //}
            //else
            //{
            //    Console.WriteLine("Bölme İşlemi Tam Bölünmez");
            //}
            //Console.WriteLine("1. sayının 2. sayıya Bölümünden Kalan : "+result);


            //Console.Write("Lütfen sayı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Girdiğiniz Sayı Çift Bir Sayıdır .");

            //}else
            //{
            //    Console.Write("Girdiğiniz Sayı Tek Bir Sayıdır.");
            //}

            #endregion

            #region char ile karar yapıları
            //char team;
            //Console.Write("Lütfen takımınızı seçin(G,F,B) : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' || team == 'g')
            //{
            //    Console.Write("Tebrikler Galatasaray'lısınız.");
            //}
            //else if (team == 'F' || team == 'f')
            //{
            //    Console.Write("Tebrikler Fenerbahçelisin.");
            //}
            //else if (team == 'B' || team == 'b')
            //{
            //    Console.Write("Tebrikler Beşiktaşlısın.");
            //}
            //else
            //{
            //    Console.Write("Lütfen geçerli bir takım seçin.");
            //}

            #endregion

            #region restaurant menü uygulaması

            //Console.WriteLine("****** FIRAT EMMİ RESTORANTA HOŞGELDİNİZ ******");
            //Console.WriteLine();
            //Console.WriteLine("-----Menü----- ");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar ");
            //Console.WriteLine("3- Pizzalar ");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar ");
            //Console.WriteLine();
            //Console.WriteLine("Lütfen Menüden Bir Seçim Yapınız : ");
            //int secim = int.Parse(Console.ReadLine());

            //if (secim==1){
            //    Console.WriteLine("***** ANA YEMEKLER *****");
            //    Console.WriteLine("1- Kuzu Tandır : 150 TL");   
            //    Console.WriteLine("2- İskender : 120 TL");
            //    Console.WriteLine("3- Adana Kebap : 100 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen Ana Yemeklerden Birini Seçiniz : ");
            //    int anaYemek = int.Parse(Console.ReadLine());

            //}
            //if (secim == 2)
            //{
            //    Console.WriteLine("***** ÇORBALAR *****");
            //    Console.WriteLine("1- Mercimek Çorbası : 30 TL");
            //    Console.WriteLine("2- Tarhana Çorbası : 25 TL");
            //    Console.WriteLine("3- Yayla Çorbası : 20 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen Çorbalardan Birini Seçiniz : ");
            //    int corba = int.Parse(Console.ReadLine());
            //}
            //if (secim == 3)
            //{
            //    Console.WriteLine("***** PİZZALAR *****");
            //    Console.WriteLine("1- Karışık Pizza : 80 TL");
            //    Console.WriteLine("2- Sade Pizza : 70 TL");
            //    Console.WriteLine("3- Sebzeli Pizza : 75 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen Pizzalardan Birini Seçiniz : ");
            //    int pizza = int.Parse(Console.ReadLine());
            //}
            //if (secim == 4)
            //{
            //    Console.WriteLine("***** İÇECEKLER *****");
            //    Console.WriteLine("1- Ayran : 10 TL");
            //    Console.WriteLine("2- Kola : 15 TL");
            //    Console.WriteLine("3- Fanta : 15 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen İçeceklerden Birini Seçiniz : ");
            //    int icecek = int.Parse(Console.ReadLine());
            //} if (secim == 5) {
            //    Console.WriteLine("***** TATLILAR *****");
            //    Console.WriteLine("1- Baklava : 50 TL");
            //    Console.WriteLine("2- Künefe : 45 TL");
            //    Console.WriteLine("3- Sütlaç : 30 TL");
            //    Console.WriteLine();
            //    Console.WriteLine("Lütfen Tatlılardan Birini Seçiniz : ");
            //    int tatli = int.Parse(Console.ReadLine());
            //}


            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Afiyet Olsun Siparişiniz Alınmıştır .");





            #endregion

            #region switch ... case Yapısı


            //Console.Write("Lütfen Bir Sayı Giriniz (1-12) : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{ case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Lütfen Geçerli Bir Ay Numarası Giriniz (1-12)");
            //        break;
            //}










            #endregion

            #region Hesap Makinesi Uygulaması

            //Console.WriteLine("*****  4 İŞLEM HESAP MAKİNESİ *****");
            //Console.WriteLine();
            //int number1, number2, result;
            //char Symbol;
            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz : ");
            //Symbol = char.Parse (Console.ReadLine());

            //switch (Symbol)
            //{ case '+':
            //       result= number1 + number2;
            //        Console.WriteLine("İŞLEM SONUCUNUZ : " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("İŞLEM SONUCUNUZ : " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("İŞLEM SONUCUNUZ : " + result); break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("İŞLEM SONUCUNUZ : " + result); break;
            //    default:
            //        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz (+,-,*,/)"); return;

            //}




            #endregion

            Console.Read();

            
        }
        
    }
}