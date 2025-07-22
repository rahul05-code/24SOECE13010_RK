using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q21
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.WriteLine();
            Console.Write("Series: ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;
                sum += term;

                Console.Write(term);
                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);

        }
    }
}
