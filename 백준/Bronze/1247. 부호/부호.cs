using System;
using static System.Console;
using System.Numerics;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int cnt = 0;
            BigInteger[] arr = new BigInteger[3];
            while (cnt < 3)
            {
                BigInteger sum = 0;
                long N = long.Parse(ReadLine());
                for (int i = 0; i < N; i++)
                {
                    BigInteger k = BigInteger.Parse(ReadLine());
                    sum += k;
                }
                arr[cnt] = sum;
                cnt++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    WriteLine(0);
                }
                else if (arr[i] < 0)
                {
                    WriteLine("-");
                }
                else if (arr[i] > 0)
                {
                    WriteLine("+");
                }
            }
        }
    }
}