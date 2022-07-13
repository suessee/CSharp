using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            double N = int.Parse(ReadLine());
            double result = 0;
            for (int i = 1; i < N+1; i++)
            {
                result += Math.Pow(i, 3);
            }
            WriteLine(result);
        }
    }
}