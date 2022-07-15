using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int B = int.Parse(ReadLine());
            int P = 5 * B - 400;
            WriteLine(P);
            if (B == 100)
            {
                WriteLine(0);
            }
            else if (B > 100)
            {
                WriteLine(-1);
            }
            else
            {
                WriteLine(1);
            }
        }
    }
}