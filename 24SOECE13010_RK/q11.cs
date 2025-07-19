using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your gender(M/F): ");
            string gen = Console.ReadLine().ToUpper();

            if (gen == "M")
            {
                Console.WriteLine("Mr. " + name);
            }
            else if(gen == "F")
            {
                Console.WriteLine("Ms. " + name);
            }
            Console.ReadLine();

        }
    }
}
