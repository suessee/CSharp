using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(ReadLine());
            int[] result = new int[t];
            for (int i = 0; i < t; i++)
            {
                string[] num = ReadLine().Split();
                int N = int.Parse(num[0]), M = int.Parse(num[1]);
                result[i] = N + M;
            }
            for (int i = 0; i < result.Length; i++)
            {
                WriteLine(result[i]);
            }
        }
    }
}