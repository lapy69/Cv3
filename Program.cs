using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A;
            double[,] B;

            A = new double[3,3]
            {
                {1,1,1},
                {1,1,1},
                {1,1,1}
            };

            B = new double[3,3]
            {
                {2,2,2},
                {2,2,2},
                {2,2,2}
            };

            Matrix A_1 = new Matrix(A);
            Matrix B_1 = new Matrix(B);
            Console.WriteLine(A_1 + B_1);
            Console.WriteLine("\n");
            Console.WriteLine(A_1 - B_1);
            Console.WriteLine("\n");
            Console.WriteLine(A_1 * B_1);
            Console.WriteLine("\n");
            Console.WriteLine(-A_1);
            Console.WriteLine("\n");
            Console.WriteLine(A_1 == B_1);
            Console.WriteLine("\n");
            Console.WriteLine(A_1 != B_1);
            Console.WriteLine("\n");
            Console.WriteLine(Matrix.Det(A_1));
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
