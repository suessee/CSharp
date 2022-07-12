using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            long N = long.Parse(ReadLine());
            long Check = N / 10000;
            if (Check == 555)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
            }
        }
    }

}