using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            double a = double.Parse(ReadLine());
            WriteLine("{0:F10}", 100 / a);
            WriteLine("{0:F10}", 100 / (100 - a));
        }
    }
}