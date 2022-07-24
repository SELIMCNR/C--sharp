using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_forAlgorıtma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 100 'e kadar olan sayıların kareleri
            for(int i = 0; i <100; i++)
            {
                Console.WriteLine("sayi{0} karesi{1}",i,i*i);
            }
            // 1 den 100 'e kadar tek  sayıları gösterme
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Sayi {0} tektir",i);
                }

            }
            // 1 den 100 'e kadar çift  sayıları gösterme
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Sayi {0} çiftir", i);
                }

            }
            

            //1000 den 0 a kadar 5 ve beşin katı olan sayılar
            for (int i = 1000; i >=0; i--)
            {
              
                if(i % 5 ==0 )
                {
                    Console.WriteLine(" sayi {0} besin katıdır",i);
                }
            }
            //carpim tablosu dışardan girilen değerlere göre
            int sayi1;
            int sayi2;  
          sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= sayi1; i++)
            {
                for( int j = 0; j <=sayi2; j++)
                {
                    Console.WriteLine("Sayi1 {0} * Sayi2 {1} = Çarpım {2}",i,j,i*j);
                }
            }


            Console.ReadLine();
        }
    }
}
