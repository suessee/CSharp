using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int Y = int.Parse(ReadLine());
            int M = int.Parse(ReadLine());
            WriteLine(M + (M - Y));
        }
    }
}