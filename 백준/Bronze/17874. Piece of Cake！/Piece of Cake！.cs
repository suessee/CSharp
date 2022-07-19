using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int n = int.Parse(num[0]), h = int.Parse(num[1]), v = int.Parse(num[2]);
            int result = Math.Max(h, n - h) * Math.Max(v, n - v)*4;
            WriteLine(result);
        }
    }
}