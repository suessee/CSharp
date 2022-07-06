using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Total = new int[2];
            for (int i = 0; i < Total.Length; i++)
            {
                string[] score = ReadLine().Split();
                int T = int.Parse(score[0]), F = int.Parse(score[1]), S = int.Parse(score[2]), P = int.Parse(score[3]), C = int.Parse(score[4]);
                Total[i] += (6 * T) + (3 * F) + (2 * S) + P + (2 * C);
            }
            WriteLine(Total[0] + " " + Total[1]);
        }
    }
}