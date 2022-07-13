using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            
            if (N % 4 == 0 || N % 4 == 2)
            {
                WriteLine("CY");
            }
            else if (N % 4 == 1 || N % 4 == 3)
            {
                WriteLine("SK");
            }
        }
    }
}