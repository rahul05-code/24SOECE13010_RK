using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q13
    {
        public static void Main(string[]args)
        {
            Console.Write("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Breakdown of notes:");

            foreach (int note in notes)
            {
                int count = amount / note;
                amount = amount % note; 

                Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
            }
        }
    }
}
