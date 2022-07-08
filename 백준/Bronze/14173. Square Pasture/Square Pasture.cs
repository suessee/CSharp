using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int X1 = int.Parse(num[0]),Y1 = int.Parse(num[1]), X2 = int.Parse(num[2]), Y2 = int.Parse(num[3]);
            string[] num1 = ReadLine().Split();
            int A1 = int.Parse(num1[0]), B1 = int.Parse(num1[1]), A2 = int.Parse(num1[2]), B2 = int.Parse(num1[3]);

            int A = Math.Max(X2, A2) - Math.Min(X1,A1);
            int B = Math.Max(Y2, B2) - Math.Min(Y1, B1);
            int result = Math.Max(A, B);
            WriteLine(result * result);
        }
    }
}