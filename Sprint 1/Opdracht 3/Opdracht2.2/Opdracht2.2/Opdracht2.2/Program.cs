using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float gewicht, lengte, bmi;

            Console.Write("Geef gewicht in kg met 1 decimaal: ");
            gewicht = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef lengte in cm: ");
            lengte = Convert.ToInt16(Console.ReadLine());

            bmi = gewicht / (lengte*lengte);

            Console.WriteLine("De bmi is " + bmi.ToString());
            Console.ReadLine();
        }
    }
}
