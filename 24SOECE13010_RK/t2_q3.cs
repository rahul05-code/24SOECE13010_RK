using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q3
    {
        static void Main(string[] args)

        {

            string firstName = "John";

            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);



            Console.WriteLine("Please enter a new first name:");

            firstName = Convert.ToString(Console.ReadLine());



            Console.WriteLine("New name: " + firstName + " " + lastName);



            Console.ReadLine();

        }
    }
}
