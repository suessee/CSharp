using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            int R = int.Parse(ReadLine());
            int S = int.Parse(ReadLine());
            int result = (R * 8 + S * 3) - 28;
            WriteLine(result);
        }
    }
}