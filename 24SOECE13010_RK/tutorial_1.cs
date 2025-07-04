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
            int x;
            
            Console.Write("Enter the number:");
            string str = Console.ReadLine();

            x = Convert.ToInt32(str);

            if(x % 2 == 0)
            {
                Console.WriteLine("Number is Even.");
            }
            else
            {
                Console.WriteLine("The Number is Odd.");
            }

            Console.ReadLine(); 

        }
    }
}
