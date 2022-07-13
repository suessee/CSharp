using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int N = int.Parse(num[0]), M = int.Parse(num[1]);
            if (M <= 2)
            {
                WriteLine("NEWBIE!");
            }
            else if (M <= N && M > 2)
            {
                WriteLine("OLDBIE!");
            }
            else
            {
                WriteLine("TLE!");
            }
        }
    }
}