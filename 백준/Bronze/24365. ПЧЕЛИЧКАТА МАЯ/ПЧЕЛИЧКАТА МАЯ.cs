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
            int result = (A + B + C) / 3;
            WriteLine((result - A) + (result - (B - (result - A))));

        }
    }
}