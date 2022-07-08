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
            string result = "";
            if (A == B && B == C)
            {
                result = "*";
            }
            else
            {
                if (A == B && A != C)
                {
                    result = "C";
                }
                else if (A == C && A != B)
                {
                    result = "B";
                }
                else
                {
                    result = "A";
                }
            }
            WriteLine(result);
        }
    }
}