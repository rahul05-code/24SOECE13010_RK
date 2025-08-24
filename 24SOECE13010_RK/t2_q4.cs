using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number (A): ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number (B): ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Integer operations
            Console.WriteLine("Integer Operations");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A - B = {A - B}");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A / B = {(B != 0 ? A / B : 0)}");
            Console.WriteLine($"A % B = {(B != 0 ? A % B : 0)}");
            Console.WriteLine($"++A = {++A}");
            Console.WriteLine($"--B = {--B}");

            // Floating point operations
            float f1 = 10.5f, f2 = 2.3f;
            Console.WriteLine("Float Operations");
            Console.WriteLine($"f1 + f2 = {f1 + f2}");
            Console.WriteLine($"f1 / f2 = {f1 / f2}");

            // Double operations
            double d1 = 15.7, d2 = 3.1;
            Console.WriteLine("Double Operations");
            Console.WriteLine($"d1 * d2 = {d1 * d2}");
            Console.WriteLine($"d1 - d2 = {d1 - d2}");

            // Decimal (for precise financial calculations)
            decimal dec1 = 100.25m, dec2 = 20.5m;
            Console.WriteLine("Decimal Operations");
            Console.WriteLine($"dec1 / dec2 = {dec1 / dec2}");

            // Relational operators
            Console.WriteLine("Relational Operators");
            Console.WriteLine($"A == B : {A == B}");
            Console.WriteLine($"A != B : {A != B}");
            Console.WriteLine($"A > B  : {A > B}");
            Console.WriteLine($"A < B  : {A < B}");

            // Logical operators
            bool b1 = true, b2 = false;
            Console.WriteLine("Logical Operators");
            Console.WriteLine($"b1 && b2 : {b1 && b2}");
            Console.WriteLine($"b1 || b2 : {b1 || b2}");
            Console.WriteLine($"!b1      : {!b1}");

            // Bitwise operators
            Console.WriteLine("Bitwise Operators");
            Console.WriteLine($"A & B = {A & B}");
            Console.WriteLine($"A | B = {A | B}");
            Console.WriteLine($"A ^ B = {A ^ B}");
            Console.WriteLine($"A << 1 = {A << 1}");
            Console.WriteLine($"B >> 1 = {B >> 1}");

            // String operations
            string s1 = "Hello", s2 = "World";
            Console.WriteLine("String Operations");
            Console.WriteLine(s1 + " " + s2);  // concatenation

            // Char operations
            char c = 'A';
            Console.WriteLine("Char Operations");
            Console.WriteLine($"Character: {c}");
            Console.WriteLine($"ASCII of {c} = {(int)c}");

            // Assignment operators
            int x = 5;
            Console.WriteLine("Assignment Operators");
            x += 3;
            Console.WriteLine($"x += 3 -> {x}");
            x *= 2;
            Console.WriteLine($"x *= 2 -> {x}");

        }
    }
}
