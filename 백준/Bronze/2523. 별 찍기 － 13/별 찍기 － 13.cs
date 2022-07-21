using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            
            int end = 1;
            for (int i = 0; i < N * 2 - 1; i++)
            {
                for (int j = 0; j < end; j++)
                {
                        Write("*");
                }
                if (i < N - 1)
                {
                    end++;
                }
                else
                {
                    end--;
                }
                WriteLine();
            }
            
        }

    }
}