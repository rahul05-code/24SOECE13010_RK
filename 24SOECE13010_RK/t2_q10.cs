using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_RK
{
    internal class t2_q10
    {
        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1; 

            while (i < N && j >= 0)
            {
                if (mat[i, j] == X)
                    return 1;
                else if (mat[i, j] > X)
                    j--; 
                else
                    i++; 
            }

            return 0; 
        }

        public static void Main(string[] args)
        {
          
            int N = 3, M = 3;
            int[,] mat = {
            { 3, 30, 38 },
            { 44, 52, 54 },
            { 57, 60, 69 }
            };
            int X = 62;

            Console.WriteLine("Search result for X={0}: {1}", X, matSearch(mat, N, M, X));

            
            N = 1; M = 6;
            int[,] mat2 = {
            { 18, 21, 27, 38, 55, 67 }
            };
            X = 55;

            Console.WriteLine("Search result for X={0}: {1}", X, matSearch(mat2, N, M, X));
        }
    }
}
