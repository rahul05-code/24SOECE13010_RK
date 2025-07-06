using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Text :");
            string input = Console.ReadLine();  

            string name = " ";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    name += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    name += char.ToUpper(c);
                }
                else
                {
                    name += c; // Keep non-alphabetic characters unchanged
                }
            }

            Console.WriteLine("Converted Text: " + name);

            Console.ReadLine();
        }
    }
}
