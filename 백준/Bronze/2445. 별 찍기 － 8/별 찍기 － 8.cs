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
            int end = N * 2 - 1;
            for (int i = 0; i < 2 * N - 1; i++)
            {
                for (int j = 0; j < N * 2; j++)
                {
                    if (j <= start || j >= end)
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
                    start++;
                    end--;
                }
                else
                {
                    start--;
                    end++;
                }
                WriteLine();
                
            }
        }
        
    }
}