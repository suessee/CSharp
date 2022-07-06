using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = N-i; j > 0; j--)
                {
                    Write("*");
                }
                WriteLine();
            }
            
            
        }
    }
}