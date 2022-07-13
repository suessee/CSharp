using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            long N = long.Parse(num[0]), W = long.Parse(num[1]), H = long.Parse(num[2]), L = long.Parse(num[3]);
            if ((W / L) * (H / L) >= N)
            {
                WriteLine(N);
            }
            else
            {
                WriteLine((W / L) * (H / L));
            }
        }
    }
}