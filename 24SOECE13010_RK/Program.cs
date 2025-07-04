using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to add:");
            Console.WriteLine("First number:");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            //c=int.Parse(Console.ReadLine());


            int sum;
            sum = a + b;

            Console.WriteLine($"The sum of {a} and {b} is:");
            Console.WriteLine(sum);

            Console.Read();
            
        }
    }
}
