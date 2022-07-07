using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            double a1 = 35 * 0.3;
            double b1 = 25 * 0.3;
            double c1 = 40 * 0.3;
            for (int i = 0; i < N; i++)
            {
                string[] input = ReadLine().Split();
                double num = double.Parse(input[0]), a = double.Parse(input[1]), b = double.Parse(input[2]), c = double.Parse(input[3]);
                if (a + b + c >= 55)
                {
                    if (a >= a1 && b >= b1 && c >= c1)
                    {
                        WriteLine(num + " " + (a + b + c) + " PASS");
                    }
                    else
                    {
                        WriteLine(num + " " + (a + b + c) + " FAIL");
                    }
                }
                else
                {
                    WriteLine(num + " " + (a + b + c) + " FAIL");
                }
            }
        }
    }
}