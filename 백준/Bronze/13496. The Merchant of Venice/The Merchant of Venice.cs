using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());
            int[] answer = new int[K]; 
            for (int i = 0; i < K; i++)
            {
                string[] num = ReadLine().Split();
                int n = int.Parse(num[0]), s = int.Parse(num[1]), d = int.Parse(num[2]);
                int sd = s * d;
                int result = 0;
                for (int j = 0; j < n; j++)
                {
                    string[] num2 = ReadLine().Split();
                    int di = int.Parse(num2[0]), vi = int.Parse(num2[1]);
                    if (sd >= di)
                    {
                        result += vi;
                    }
                }
                answer[i] = result;
            }
            for (int i = 0; i < answer.Length; i++)
            {
                WriteLine("Data Set " + (i + 1) + ":\n" + answer[i]);
                if (i == answer.Length - 1)
                {
                    break;
                }
                WriteLine();
            }
        }
    }
}