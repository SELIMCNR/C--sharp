using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ALGORITMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UYGULAMALAR  
           int ay = 1;
           string sonuc = "";

           if (ay == 1)
            {
                sonuc = "OCAK";

                Console.WriteLine($"{sonuc} ayındayız");
            }

           else if (ay == 2)
            {
                sonuc = "ŞUBAR";

                Console.WriteLine($"{sonuc} ayındayız");
            }
            else if (ay == 4)
            {
                sonuc = "MART";

                Console.WriteLine($"{sonuc} ayındayız");
            }
            else if (ay == 5)
            {
                sonuc = "NİSAN";

                Console.WriteLine($"{sonuc} ayındayız");
            }
            else if (ay ==6)
            {
                sonuc = "MAYIS";

                Console.WriteLine($"{sonuc} ayındayız");
            }
            else if (ay == 7)
            {
                sonuc = "HAZİRAN";

                Console.WriteLine($"{sonuc} ayındayız");
            }
           else
            {
                Console.WriteLine("Yanlış numara");
            }

           int yas = 25;
            if(yas<18)
            {
                Console.WriteLine("SİTEYE GİRİŞ YASAK");
            }
            else
            {
                Console.WriteLine("SİTEYE GİREBİLİRSİN");
            }
           

            int sayi1 = 15;
            int sayi2 = 25;
            int sayi3 = 35;

            if(sayi1 > sayi2 && sayi1>sayi3)
            {
                Console.WriteLine("En buyuk sayi {0}",sayi1);
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("En buyuk sayi {0}", sayi2);
            }
            else if (sayi3 > sayi2 && sayi3 > sayi2)
            {
                Console.WriteLine("En buyuk sayi {0}", sayi3);
            }
            Console.ReadLine();
        }
    }
}
