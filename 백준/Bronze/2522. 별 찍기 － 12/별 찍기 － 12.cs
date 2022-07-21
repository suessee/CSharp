using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            
            int start = N - 1;
            for (int i = 0; i < N * 2 - 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j >= start)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                if (i < N - 1)
                {
                    start--;
                }
                else
                {
                    start++;
                }
                WriteLine();
            }
            
        }

    }
}