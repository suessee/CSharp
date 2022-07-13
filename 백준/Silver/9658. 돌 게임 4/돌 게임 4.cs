using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            if (N % 7 == 1 || N % 7 == 3)
            {
                WriteLine("CY");
            }
            else
            {
                WriteLine("SK");
            }
        }
    }
}