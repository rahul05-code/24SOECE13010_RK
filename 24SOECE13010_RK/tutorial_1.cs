using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class tutorial_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to chek odd or even");
            Console.WriteLine("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine($"The {a} is even.");
            }
            else
            {
                Console.WriteLine($"The {a} is odd.");
            }

            Console.ReadLine(); 

        }
    }
}
