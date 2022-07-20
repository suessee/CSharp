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
            double a = A % 4;
            double b = B % 4;

            if (a % 4 == 0)
            {
                a = 4;
            }

            if (b % 4 == 0)
            {
                b = 4;
            }

            double c = (int)(A / 4);
            double d = (int)(B / 4);
            
            if (c < A / 4 )
            {
                c += 1;
            }
            
            if (d < B / 4)
            {
                d += 1;
            }
            
            double result = Math.Abs(a - b) + Math.Abs(c - d);
            WriteLine(result);
        }
    }
}