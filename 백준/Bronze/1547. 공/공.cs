using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int M = int.Parse(ReadLine());
            int ball = 1;
            for (int i = 0; i < M; i++)
            {
                string[] num = ReadLine().Split();
                int X = int.Parse(num[0]), Y = int.Parse(num[1]);
                if (X == ball)
                {
                    ball = Y;
                }
                else if (Y == ball)
                {
                    ball = X;
                }
            }
            WriteLine(ball);
        }
    }
}