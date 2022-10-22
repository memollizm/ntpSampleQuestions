using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 13;
            int z = 42;
            bool soru1 = 23 == 55 && 76 > 45 && 5 < 12; //False
            bool soru2 = 23 >= 23 && 45 != 18; //True
            bool soru3 = x > y && z == y && z < x; //False
            bool soru4 = z > x && y < x; //True
            bool soru5 = x != z || y <= z; //True

            Console.WriteLine(soru1);
            Console.WriteLine(soru2);
            Console.WriteLine(soru3);
            Console.WriteLine(soru4);
            Console.WriteLine(soru5);

            Console.ReadKey();
        }
    }
}
