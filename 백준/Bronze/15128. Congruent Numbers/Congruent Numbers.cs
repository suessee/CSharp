using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {


            string[] num = ReadLine().Split();
            long p1 = long.Parse(num[0]), q1 = long.Parse(num[1]), p2 = long.Parse(num[2]), q2 = long.Parse(num[3]);
            bool answer = ((p1*p2) % (q1 * q2 * 2) == 0);
            if (answer == true)
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