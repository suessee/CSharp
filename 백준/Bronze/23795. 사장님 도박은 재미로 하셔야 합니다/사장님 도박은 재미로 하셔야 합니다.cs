using System;
using static System.Console;
using System.Numerics;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            BigInteger result = 0;
            while (true)
            {
                BigInteger a = int.Parse(ReadLine());
                if (a == -1)
                {
                    break;
                }
                result += a;
            }
            WriteLine(result);
        }

    }
}