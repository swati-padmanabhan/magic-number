using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double areaOfCircle = 3.14 * radius * radius; 
            // here the value of "pi" that is 3.14 is a magic number because it has been hard coded
            // instead, we should have declared a const and assign 3.14 to the variable "pi"
            Console.WriteLine("Area of Circle is: " + areaOfCircle);

        }
    }
}
