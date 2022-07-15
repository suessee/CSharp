using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]);
            int result = 0;

            int max1 = Math.Max(A, B);
            int max2 = Math.Max(max1, C);
            result = (max2 - A) + (max2 - B) + (max2 - C);
            WriteLine(result);
        }
    }
}