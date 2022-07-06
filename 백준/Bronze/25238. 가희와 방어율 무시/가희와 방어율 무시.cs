using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string[] num1 = ReadLine().Split();
            double a = double.Parse(num1[0]), b = double.Parse(num1[1]);
            if (a >=100)
            {
                result += a - (a * (b / 100));
                if (result >= 100)
                {
                    WriteLine(0);
                }
                else
                {
                    WriteLine(1);
                }
            }
            else
            {
                WriteLine(1);
            }
        }
    }
}