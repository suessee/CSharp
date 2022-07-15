using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]);
            int result1 = Math.Max(A + B, A - B);
            int result2 = Math.Min(A + B, A - B);
            WriteLine(result1 + "\n" + result2);
        }
    }
}