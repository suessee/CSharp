using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            
            int start = 0;
            int end = N * 2 - 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 2 - i; j++)
                {
                    if (j >= start && j <= end)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                start++;
                end--;
                WriteLine();
            }
            start--;
            end++;
            for (int i = N - 2; i >= 0; i--)
            {
                start--;
                end++;
                for (int j = 0; j < N * 2 - i; j++)
                {
                    if (j >= start && j <= end)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }                
                WriteLine();
            }
        }

    }
}