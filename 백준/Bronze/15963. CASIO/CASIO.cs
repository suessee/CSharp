using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            long N = long.Parse(num[0]), M = long.Parse(num[1]);
            if (N == M)
            {
                WriteLine(1);
            }
            else
            {
                WriteLine(0);
            }
            

        }
    }

}