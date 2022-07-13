using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int S = int.Parse(ReadLine());
            int M = int.Parse(ReadLine());
            int L = int.Parse(ReadLine());
            int happy = S + 2 * M + 3 * L;
            if (happy >= 10)
            {
                WriteLine("happy");
            }
            else
            {
                WriteLine("sad");
            }
        }
    }
}