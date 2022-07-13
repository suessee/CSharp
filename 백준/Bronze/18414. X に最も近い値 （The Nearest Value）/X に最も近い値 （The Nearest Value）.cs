using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int X = int.Parse(num[0]), L = int.Parse(num[1]), R = int.Parse(num[2]);
            int result = X;
            int answer = 0;
            if (X >= L)
            {
                if (X <= R)
                {
                    answer = X;
                }
                else if (X > R)
                {
                    for (int i = R; i >= L; i--)
                    {
                        if (Math.Abs(X - i) < result)
                        {
                            result = Math.Abs(X - i);
                            answer = i;
                        }
                    }
                }
            }
            else
            {
                answer = L;
            }
            WriteLine(answer);

        }
    }
}