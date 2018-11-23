using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal1, Getal2, Som1, Som2, Som3, Som4, Som5, Som6, Som7, Som8;

            Console.Write("Geef getal 1: ");
            Getal1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geef getal 2: ");
            Getal2 = Convert.ToInt16(Console.ReadLine());

            Som1 = Getal1 + Getal2;
            Som2 = Getal1 - Getal2;
            Som3 = Getal2 - Getal1;
            Som4 = Getal1 * Getal2;
            Som5 = Getal1 / Getal2;
            Som6 = Getal2 / Getal1;
            Som7 = Getal1 %= Getal2;
            Som8 = Getal2 %= Getal1;

            Console.WriteLine("\r\n" +
            "Eerste getal plus tweede getal " + Som1.ToString() + "\r\n" + 
            "Eerste getal min tweede getal " + Som2.ToString() +"\r\n" +
            "Tweede getal min eerste getal " + Som3.ToString() +"\r\n" +
            "Eerste getal maal tweede getal " + Som4.ToString() +"\r\n" +
            "Eerste getal gedeeld door tweede getal " + Som5.ToString() +"\r\n" +
            "Tweede getal gedeeld door eerste getal " + Som6.ToString() + "\r\n" +
            "Restant van eerste getal gedeeld door tweede getal " + Som7.ToString() + "\r\n" +
            "Restant van tweede getal gedeeld door eerste getal " + Som8.ToString());
            Console.ReadLine();
        }
    }
}