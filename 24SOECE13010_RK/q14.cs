using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();

            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            foreach (char digit in number)
            {
                int d = digit - '0';
                Console.Write(words[d] + " ");
            }

            Console.WriteLine();
        }
    }
}
