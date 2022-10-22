using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int derece;
            double derToRad , derToGrad;
            double radyan, gradyan;

            Console.Write("Lütfen bir derece değeri giriniz: ");
            derece = Convert.ToInt32(Console.ReadLine());

            radyan = 180 / Math.PI;
            derToRad = derece / radyan;

            gradyan = 1.11111111111111;
            derToGrad = derece * gradyan;

            Console.WriteLine(derece+" derece "+derToRad+" radyana eşittir.");
            Console.WriteLine(derece+" derece "+derToGrad+" gradyana eşittir.");


            Console.ReadKey();
        }
    }
}
