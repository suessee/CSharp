using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            string[] num = ReadLine().Split();
            long A = long.Parse(num[0]), B = long.Parse(num[1]), C = long.Parse(num[2]);
            double ABC = (double)(A*B)/C;
            double ABC2 = ((double)A/B)*C;
            WriteLine(Math.Max((long)ABC, (long)ABC2));
        }
    }

}