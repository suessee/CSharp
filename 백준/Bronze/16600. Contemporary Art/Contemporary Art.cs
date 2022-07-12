using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            long a = long.Parse(ReadLine());
            double result = Math.Sqrt(a)*4;
            WriteLine(result);
        }
    }

}