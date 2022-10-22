using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double diskriminant;
            Console.WriteLine("ax2 + bx + c = 0 formatında ki denklemi yazınız...");
            
            Console.Write("a değerini giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b değerini giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c değerini giriniz: ");
            c = Convert.ToInt32(Console.ReadLine());

            diskriminant = (b * b) - (4 * a * c);

            if(diskriminant > 0)
            {
                double kok1 = ((-b - Math.Sqrt(diskriminant)) / (2 * a));
                double kok2 = ((-b + Math.Sqrt(diskriminant)) / (2 * a));
                Console.WriteLine("Denklemin kökleri: " + kok1 + " ve " + kok2);
            }

            else if(diskriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin kökü: " + x);
            }

            else
            {
                Console.WriteLine("Denklemin reel değil sanal kökü vardır.");
            }

            Console.ReadKey();
        }
    }
}
