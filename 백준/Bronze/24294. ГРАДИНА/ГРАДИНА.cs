using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int w1 = int.Parse(ReadLine());
            int h1 = int.Parse(ReadLine());
            int w2 = int.Parse(ReadLine());
            int h2 = int.Parse(ReadLine());
            int result = 2 * Math.Max(w1, w2) + 2 * (h1 + h2) + 4;
            WriteLine(result);
        }
    }
}