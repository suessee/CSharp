using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]);
            int Coke = A / 2;
            int result = 0;
            if (Coke < N)
            {
                if (N - Coke >= B)
                {
                    result = Coke + B;
                }
                else
                {
                    result = N;
                }
            }
            else
            {
                result = N;
            }
            WriteLine(result);
        }
    }
}