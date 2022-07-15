using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            long N = long.Parse(num[0]), M = long.Parse(num[1]);
            long result = 0;
            if (N > 1 && M > 1)
            {
                result = Math.Min(N / 2 , M / 2);
            }
            else
            {
                result = 0;
            }
            WriteLine(result);
        }
    }
}