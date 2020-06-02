using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtamaVeMatematikOperatorleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 5;
            //int sayi2;
            //int sayi3;

            //sayi2 = sayi1;
            //sayi3 = sayi1;
            //Console.WriteLine(sayi1);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            //Console.Read();

            //int s1, s2, s3;
            //s1 = 10;
            //s2 = 15;
            //s3 = 20;
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);

            //Console.Read();

            int sayi1 = 10;
            int sayi2 = 5;

            int toplam;
            int fark;
            int carpim;
            double bolum;
            int mod;//bölümden geriye kalan sayı.

            //Toplama
            toplam = sayi1 + sayi2;

            //Çıkartma
            fark = sayi1 - sayi2;

            //Carpim
            carpim = sayi1 * sayi2;

            //Bölme
            bolum = sayi1 / sayi2;

            //Mod
            mod = sayi1 % sayi2;

            Console.WriteLine(toplam);
            Console.WriteLine(fark);
            Console.WriteLine(carpim);
            Console.WriteLine(bolum);
            Console.WriteLine(mod);

            Console.Read();

        }
    }
}
