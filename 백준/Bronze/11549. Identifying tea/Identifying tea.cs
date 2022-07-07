using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int T = int.Parse(ReadLine());
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]), D = int.Parse(num[3]), E = int.Parse(num[4]);
            int[] result = { A, B, C, D, E };
            int answer = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == T)
                {
                    answer++;
                }
            }
            WriteLine(answer);
        }
    }
}