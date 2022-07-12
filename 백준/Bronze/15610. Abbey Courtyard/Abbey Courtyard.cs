using System;
using static System.Console;
using System.Numerics;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            BigInteger a = BigInteger.Parse(ReadLine());
            double result = Math.Sqrt((double)a) * 4;
            WriteLine(result);
        }
    }

}