using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int N = int.Parse(num[0]), M = int.Parse(num[1]);
            int[,] A = new int[N, M];

            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    string[] input = ReadLine().Split();
                    for (int j = 0; j < M; j++)
                    {
                        A[i, j] += int.Parse(input[j]);
                    }
                }
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Write(A[i, j] + " ");
                }
                WriteLine();
            }
        }
    }
}