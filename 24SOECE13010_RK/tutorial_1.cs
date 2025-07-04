using System; //system name space provide input/output
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK //name space for program
{
    internal class tutorial_1 //class name
    {
        public static void Main(string[] args)//main method
        {
            int n, fact=1; //n variable declare and fact initializes
            
            Console.Write("Enter the number:"); //prompts for user enter 
            string str = Console.ReadLine(); // reads input

            n = Convert.ToInt32(str); //converts string to intrger

            for (int i = 1; i <= n; i++) //loops from 1 to 'n'
            {
                fact = fact * i; //Calculates factorial by multiplying 'fact' with 'i' in each iteration
            }

            Console.WriteLine("Factorial : {0}",fact);//display calculated factorial

            Console.Read(); // waits for user to press a key before closing the console window

        }
    }
}
