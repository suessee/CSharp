using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] Nums = new int[N];
            int cnt = 0;

            string[] input = ReadLine().Split();

            while (cnt < N) 
            {
                int a = int.Parse(input[cnt]);
                Nums[cnt] = a;
                cnt++;
            }
            int v = int.Parse(ReadLine());
            cnt = 0;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] == v)
                {
                    cnt++;
                }
            }
            WriteLine(cnt);
        }
    }
}