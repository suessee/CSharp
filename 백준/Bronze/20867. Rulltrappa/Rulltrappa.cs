using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int M = int.Parse(num[0]), S = int.Parse(num[1]), G = int.Parse(num[2]);
            string[] num1 = ReadLine().Split();
            double A = double.Parse(num1[0]), B = double.Parse(num1[1]);
            string[] num2 = ReadLine().Split();
            int L = int.Parse(num2[0]), R = int.Parse(num2[1]);
            double walk = (1 / A) * L + (double)M / (double)G;
            double wait = (1 / B) * R + (double)M / (double)S;
            if (walk < wait)
            {
                WriteLine("friskus");
            }
            else
            {
                WriteLine("latmask");
            }
        }
    }
}