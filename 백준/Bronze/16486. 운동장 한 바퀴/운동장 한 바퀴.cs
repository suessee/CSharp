using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int d1 = int.Parse(ReadLine());
            int d2 = int.Parse(ReadLine());
            double result = d1 * 2 + Math.PI * 2 * d2;
            WriteLine(result);
        }
    }

}