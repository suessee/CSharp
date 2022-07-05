using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = ReadLine();

            for (int i = input.Length-1; i >= 0; i--)
            {
                Write(input[i]);
            }
        }
    }
}