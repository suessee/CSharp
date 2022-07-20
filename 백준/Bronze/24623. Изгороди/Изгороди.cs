using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int n = int.Parse(ReadLine());
            double a = int.Parse(ReadLine());
            WriteLine((180 - a) / 2 + a / 2);
        }
    }
}