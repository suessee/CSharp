using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            if (N % 7 == 0 || N % 7 == 2)
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