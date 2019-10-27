using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Aplikacja
    {
        static void Main(string[] args)
        {
            Samochód s = new Samochód();
            Samochód s1 = new Samochód();
            s1.Marka = "honda";
            s1.Model = "Civic";
            s1.Drzwi = 3;
            s1.Pojemnosc = 2.00;
            s1.Spalanie = 8.00;
            Samochód s2 = new Samochód("cos", "costam", 2, 2.0, 10.0);
            Console.WriteLine(s1.SpalanieTrasa(50));
            Console.WriteLine(s1.CenaPaliwo(10, 5));
            Console.WriteLine(s1.info);
            Console.WriteLine(s2.SpalanieTrasa(50));
            Console.WriteLine(s2.CenaPaliwo(10, 5));
            Console.WriteLine(s2.info);
            Console.WriteLine(s.LiczbaSamochodów);
            Samochód s3 = new Samochód();
            Console.WriteLine(s.LiczbaSamochodów);
            Console.ReadKey();

                
        }
    }
}
