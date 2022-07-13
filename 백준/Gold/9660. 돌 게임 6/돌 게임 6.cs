using System;
using static System.Console;
using System.Numerics;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            BigInteger N = BigInteger.Parse(ReadLine());
            if (N % 7 == 0 || N % 7 == 2)
            {
                WriteLine("CY");
            }
            else
            {
                WriteLine("SK");
            }
        }
    }
}