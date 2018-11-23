using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            DateTime dob;
            DateTime today = DateTime.Now;

            Console.WriteLine("Voer uw geboorte jaar in als dd-mm-jjjj:");
            dob = Convert.ToDateTime(Console.ReadLine()).Date;
            Console.WriteLine("Voer uw naam in:");
            name = (Console.ReadLine());

            TimeSpan difference = today.Subtract(dob);

            age = difference.Days / 365;

            Console.WriteLine(name + " is " + age + " jaar oud");
            Console.ReadLine();
        }
    }
}
