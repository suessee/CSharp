using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());

            if (A == B && B == C)
            {
                WriteLine("Equilateral");
            }
            else if (A + B + C == 180)
            {
                if (A == B || B == C || C == A)
                {
                    WriteLine("Isosceles");
                }
                else if (A != B && B != C)
                {
                    WriteLine("Scalene");
                }
            }
            else if (A + B + C != 180)
            {
                WriteLine("Error");
            }
        }
    }
}