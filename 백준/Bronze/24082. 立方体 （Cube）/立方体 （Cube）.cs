using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            int X = int.Parse(ReadLine());
            
            WriteLine(Math.Pow(X,3));
        }
    }
}