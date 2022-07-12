using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            double A = double.Parse(num[0]), B = double.Parse(num[1]);
            double M = (B - A) / 400;
            double result = 1 / (1 + Math.Pow(10, M));
            WriteLine(result);
        }
    }

}