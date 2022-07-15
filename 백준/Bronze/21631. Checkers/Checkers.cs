using System;
using static System.Console;
using System.Numerics;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            BigInteger a = BigInteger.Parse(num[0]), b = BigInteger.Parse(num[1]);
            if (a >= b)
            {
                WriteLine(b);
            }
            else if (a < b && b != 0)
            {
                WriteLine(a + 1);
            }

        }
    }
}