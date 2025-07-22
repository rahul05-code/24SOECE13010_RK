using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q20
    {
        public static void Main(string[] args)
        {
            int num = 4;
            int n = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(n+" ");
                    n++;
                }

                Console.WriteLine();

            }
        }
    }
}
