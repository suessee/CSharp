using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]);
            string result = "N";
            if (A == B || A == C || B == C)
            {
                result = "S";
            }
            else
            {
                if (A+B == C || A+C == B || B+C == A)
                {
                    result = "S";
                }
            }
            WriteLine(result);
        }
    }
}