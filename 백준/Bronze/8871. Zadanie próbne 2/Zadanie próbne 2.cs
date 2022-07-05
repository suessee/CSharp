using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(ReadLine());
            Write(input * 2 + 2 * 1 + " ");
            Write(input * 3 + 3 * 1);
        }
    }
}