using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            double w = double.Parse(num[0]), h = double.Parse(num[1]);
            double result =  (2 * w + 2 * h)- (Math.Sqrt(Math.Pow(w, 2) + Math.Pow(h, 2)) + w + h);
            WriteLine(result);
        }
    }
}