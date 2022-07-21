using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            int start = -1;
            int end = N * 2;
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < N + i; j++)
                {
                    if (j > start && j < end)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
                start++;
                end--;
            }
        }
        
    }
}