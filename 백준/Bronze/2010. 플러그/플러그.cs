using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                int A = int.Parse(ReadLine());
                if (i != N-1)
                {
                    result -= 1;
                }
                result += A;
            }
            WriteLine(result);
        }
    }
}