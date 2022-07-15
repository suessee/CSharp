using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0])*7, P = int.Parse(num[1])*13;
            if (A == P)
            {
                WriteLine("lika");
            }
            else if (A < P)
            {
                WriteLine("Petra");
            }
            else if (A > P)
            {
                WriteLine("Axel");
            }
        }
    }
}