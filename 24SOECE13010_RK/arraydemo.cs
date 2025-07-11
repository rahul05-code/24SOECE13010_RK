using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class arraydemo
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] {1,2,3,4,5};
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element at index {0} is: {1}", i, arr[i]);
            }

            foreach (int element in arr)
            {
                Console.WriteLine("Element: " + element);
            }
        }
    }
}
