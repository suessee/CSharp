using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            double A1 = double.Parse(num[0]), P1 = double.Parse(num[1]);
            string[] num1 = ReadLine().Split();
            double R1 = double.Parse(num1[0]), P2 = double.Parse(num1[1]);
            double result = (R1 * R1 * Math.PI)/P2;
            if (A1/P1 < result)
            {
                WriteLine("Whole pizza");
            }
            else if(A1 / P1 > result)
            {
                WriteLine("Slice of pizza");
            }
        }
    }

}