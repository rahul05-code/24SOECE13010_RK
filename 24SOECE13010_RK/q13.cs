using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q13
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");

            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.ReadLine();
        }
    }
}
