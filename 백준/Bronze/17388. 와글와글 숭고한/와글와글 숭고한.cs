using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int S = int.Parse(num[0]), K = int.Parse(num[1]), H = int.Parse(num[2]);
            int min = Math.Min(S, K);
            int Rmin = Math.Min(min, H);
            int sum = S + K + H;
            if (sum < 100)
            {
                if (Rmin == S)
                {
                    WriteLine("Soongsil");
                }
                else if (Rmin == K)
                {
                    WriteLine("Korea");
                }
                else if (Rmin == H)
                {
                    WriteLine("Hanyang");
                }
            }
            else
            {
                WriteLine("OK");
            }
        }
    }

}