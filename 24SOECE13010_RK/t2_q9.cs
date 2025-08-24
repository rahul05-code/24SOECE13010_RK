using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q9
    {
        public static void Main(string[] args)
        {
     
            int[] arr = { 2, 1, 3, 2};

            int xor = 0;

            
            foreach (int num in arr)
            {
                xor ^= num;
            }

            
            int rightmostSetBit = xor & -xor;

            int num1 = 0, num2 = 0;

            
            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                    num1 ^= num;
                else
                    num2 ^= num;
            }

            Console.WriteLine("The two unique numbers are: {0} {1}", num1, num2);
        }
    }
}
