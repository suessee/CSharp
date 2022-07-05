using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = ReadLine().Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]), K = int.Parse(input[2]);
            int[,] baseB = new int[N, M];
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    baseB[i, j] = cnt;
                    cnt++;
                    if (baseB[i, j] == K)
                    {
                        WriteLine("{0} {1}",i,j);
                    }
                }
               
            }
        }
    }
}