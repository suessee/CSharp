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

            WriteLine(B-A);
        }
    }
}