using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int wc = int.Parse(num[0]), hc = int.Parse(num[1]), ws = int.Parse(num[2]), hs = int.Parse(num[3]);
            if (wc >= ws + 2 && hc >= hs +2)
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