using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            double N = int.Parse(ReadLine());
            WriteLine(Math.Pow(2, N));
        }
    }
}