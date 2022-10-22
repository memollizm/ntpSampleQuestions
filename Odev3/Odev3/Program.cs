using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            

            Console.Write("Lütfen 1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                if(sayi1 % sayi2 == 0)
                {
                    Console.WriteLine(sayi1+" sayısı "+sayi2+" sayısına tam olarak bölünür.");
                }
                else
                {
                    Console.WriteLine(sayi1+" sayısı "+sayi2+" sayısına tam olarak bölünemez.");
                }
            }
            else
            {
                if(sayi2 % sayi1 == 0)
                {
                    Console.WriteLine(sayi2 + " sayısı "+sayi1+" sayısına tam olarak bölünür.");
                }
                else
                {
                    Console.WriteLine(sayi2+" sayısı "+sayi1+" sayısına tam olarak bölünemez.");
                }
            }

            Console.ReadKey();

        }
    }
}
