using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            int result = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                string[] num = ReadLine().Split();
                int A = int.Parse(num[0]), B = int.Parse(num[1]);
                if (A <= B && result > B)
                {
                    result = B;

                }
            }
            if (result == 2147483647)
            {
                WriteLine(-1);
            }
            else
            {
                WriteLine(result);
            }
                     
        }

    }
}