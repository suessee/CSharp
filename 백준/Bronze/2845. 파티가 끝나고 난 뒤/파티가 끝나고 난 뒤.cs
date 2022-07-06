using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int L = int.Parse(num[0]), P = int.Parse(num[1]);
            int total = L * P;

            string[] num1 = ReadLine().Split();
            int A = int.Parse(num1[0]), B = int.Parse(num1[1]), C = int.Parse(num1[2]), D = int.Parse(num1[3]), E = int.Parse(num1[4]);

            WriteLine((A - total) + " " + (B - total) + " " + (C - total) + " " + (D - total) + " " + (E - total));

        }
    }
}