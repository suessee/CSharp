using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            if (N == 0)
            {
                WriteLine("divide by zero");
            }
            else
            {
                string[] num = ReadLine().Split();
                double result = 0;
                double Ex = 0;
                double answer = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    result += double.Parse(num[i]);
                }
                result /= N;
                for (int i = 0; i < num.Length; i++)
                {
                    Ex += double.Parse(num[i]) /N;
                }
                answer = result / Ex;
                WriteLine("{0:0.00}",Math.Round(answer,2));
            }

        }
    }

}