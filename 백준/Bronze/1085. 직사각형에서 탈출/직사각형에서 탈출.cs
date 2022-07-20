using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int x = int.Parse(num[0]), y = int.Parse(num[1]), w = int.Parse(num[2]), h = int.Parse(num[3]);
            int min1 = Math.Min(x, y);
            int min2 = Math.Min(w - x, h - y);
            int min = Math.Min(min1, min2);
            WriteLine(min);
        }
    }
}