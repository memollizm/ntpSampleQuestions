using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 48 / 6 / 4; // Soldan sağa doğru
            int y = 24 / 3 * 2; // Soldan sağa doğru
            int z = (7+4) * 2 - 1 + 8 / 2; // Önce üs alma daha sonra matematiksel sırayla
            double sonuc1 = (5-1)*2-1+Math.Pow(7,2); // Önce parantez içi daha sonra matematiksel sırayla
            double sonuc2 = Math.Pow(2,2)+5-1+4; // Önce üs alma daha sonra matematiksel sırayla
            
            Console.WriteLine("48 / 6 / 4 = " + x);
            Console.WriteLine("24 / 3 * 2 = " + y);
            Console.WriteLine("(7+4) * 2 - 1 + 8 / 2 = " + z);
            Console.WriteLine("(5-1)*2-1+Math.Pow(7,2) = "+sonuc1);
            Console.WriteLine("(Math.Pow(2,2))+5-1+4 = " + sonuc2);

            Console.ReadKey();



        }
    }
}
