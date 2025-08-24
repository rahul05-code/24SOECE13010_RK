using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q11
    {
        public static void Main(string[]args)
        {
            Console.Write("Enter number of elements (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];
            int sum = 0;

            Console.WriteLine("Enter {0} elements:", N);
            for (int i = 0; i < N; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i]; 
            }

            Console.WriteLine("Sum of array elements = " + sum);
        }
    }
}
