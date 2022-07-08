using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            double A = double.Parse(ReadLine());

            double result = Math.Round((3.785411784 / (1609.344 * A)) * 100000,6);

            WriteLine(result);
        }
    }
}