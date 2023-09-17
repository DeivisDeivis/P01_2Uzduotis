using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_2Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Fxy;

            Console.WriteLine("Iveskite x reiksme");
           double x= double.Parse(Console.ReadLine());
            
            Console.WriteLine("Iveskite y reiksme ");
                double y = double.Parse(Console.ReadLine());

            Fxy = ((y * y)- (2*y*x) + (x*x))/ ((x*x*x)-y);
            Console.WriteLine(Fxy);

        }
    }
}
