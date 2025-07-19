using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q15
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");

            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int temp = n;
            while (temp > 0)
            {
                int d = temp % 10;
                a += d * d * d;
                temp /= 10;
            }

            if(a == n)
            {
                Console.WriteLine(n+" Is Armstrong number");
            }
            else
            {
                Console.WriteLine(n+" Not an Armstrong number");
            }   
            Console.ReadLine();
        }
    }
}
