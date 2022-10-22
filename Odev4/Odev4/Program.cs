using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ay;
            string[] tarihDizi;

            Console.Write("Lütfen gg.aa.yyyy formatında bir giriş yapın: ");
            ay = Console.ReadLine();
            tarihDizi = ay.Split('.');   //gun.Split('.') komutu noktaya kadar olan yerleri parçalayarak    
                                        // diziye atar. gunDizi[0] , gunDizi[1] , gunDizi[2] gibi...
            
            if (int.Parse(tarihDizi[1]) == 1)
            {
                Console.WriteLine("Ocak ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 2)
            {
                Console.WriteLine("Şubat ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 3)
            {
                Console.WriteLine("Mart ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 4)
            {
                Console.WriteLine("Nisan ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 5)
            {
                Console.WriteLine("Mayıs ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 6)
            {
                Console.WriteLine("Haziran ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 7)
            {
                Console.WriteLine("Temmuz ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 8)
            {
                Console.WriteLine("Ağustos ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 9)
            {
                Console.WriteLine("Eylül ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 10)
            {
                Console.WriteLine("Ekim ayındayız....");
            }
            else if (int.Parse(tarihDizi[1]) == 11)
            {
                Console.WriteLine("Kasım ayındayız...");
            }
            else if (int.Parse(tarihDizi[1]) == 12)
            {
                Console.WriteLine("Aralık ayındayız...");
            }
            else
            {
                Console.WriteLine("Geçersiz değer girişi !!");
            }
            
            
            Console.ReadKey();


        }
    }
}
