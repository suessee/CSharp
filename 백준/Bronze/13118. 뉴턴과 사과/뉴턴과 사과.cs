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
            BigInteger p1 = BigInteger.Parse(num[0]), p2 = BigInteger.Parse(num[1]), p3 = BigInteger.Parse(num[2]), p4 = BigInteger.Parse(num[3]);
            string[] num1 = ReadLine().Split();
            BigInteger x = BigInteger.Parse(num1[0]), y = BigInteger.Parse(num1[1]), r = BigInteger.Parse(num1[2]);
            BigInteger[] arr = { p1, p2, p3, p4 };
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x - r || arr[i] == x + r || arr[i] == x)
                {
                    result = i + 1;
                }
            }
            WriteLine(result);
        }

    }
}