using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1_MuratYucedag
{
    class Program
    {
        static void Main(string[] args)
        {
            //01.10.2024 C# Eğitim Kampı Ders 2 Görev 1 
            double akbilucret;
            akbilucret = 22.75;
            Console.WriteLine(akbilucret);
            Console.WriteLine("--");
            Console.WriteLine("--");

            double girisucret, saatucret, geneltoplam;
            girisucret = 3.75;
            saatucret = 2.10;
            geneltoplam = girisucret * saatucret;
            Console.WriteLine(geneltoplam);
            Console.WriteLine("--");
            Console.WriteLine("--");

            char tekKarakter;
            tekKarakter = 'a';
            Console.WriteLine(tekKarakter);
            Console.WriteLine("--");
            Console.WriteLine("--");
            Console.ReadKey();

            int s1, s2, toplam;
            Console.Write("1. Sayıyı giriniz: ");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("2. Sayıyı giriniz: ");
            s2 = Convert.ToInt16(Console.ReadLine());

            toplam = s1 + s2;

            Console.WriteLine("Toplam : " + toplam);
            Console.ReadKey();

            Console.WriteLine("--");
            Console.WriteLine("--");

            string ad, soyad;
            Console.Write("Adınızı girin:");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı girin:");
            soyad = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " + ad + " " + soyad);
            Console.ReadKey();

            Console.WriteLine("--");
            Console.WriteLine("--");

            double result;
            Console.Write("Lütfen bir sayı girin: ");
           result = double.Parse(Console.ReadLine());
            Console.WriteLine("Girilen sayı (double olarak): " + result);

        }
    }
}
