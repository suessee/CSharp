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
            string[] num1 = ReadLine().Split();
            int C = int.Parse(num1[0]), D = int.Parse(num1[1]);
            int AD = A+D;
            int BC = B+C;
            if (AD >= BC)
            {
                WriteLine(BC);
            }
            else
            {
                WriteLine(AD);
            }
            
        }
    }
}