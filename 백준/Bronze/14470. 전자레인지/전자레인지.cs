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
            int D = int.Parse(ReadLine());
            int E = int.Parse(ReadLine());
            int result = 0;

            if (A < 0)
            {
                result = (Math.Abs(A) * C )+ D + (B * E);
            }
            else
            {
                result = (B - A) * E; 
            }
            WriteLine(result);
        }
    }
}