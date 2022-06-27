using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc;
            var islem ="topla";
            if(islem =="topla")
            {
                sonuc=topla(50, 100);
                Console.WriteLine(sonuc);
            }
            else
            {
                sonuc = cikar(100, 50);
                Console.WriteLine(sonuc);
            }
            Console.ReadLine();


        }
        static int topla(int number1, int number2)
        {
            return number1 + number2;

        }
        static int cikar(int number1, int number2)
        {
            return number1 + number2;

        }

    }
}
