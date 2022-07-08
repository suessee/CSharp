using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]);
            int result = 0;
            if (A == B)
            {
                result = A;
            }
            else
            {
                if (A > B)
                {
                    result = A;
                }
                else
                {
                    result = B;
                }
            }
            WriteLine(result);
        }
    }
}