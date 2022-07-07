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
            string[] answer = new string[N];
            
            for (int i = 0; i < N; i++)
            {
                string result = "";
                string input = ReadLine();
                for (int j = input.Length - 1; j >= 0; j--)
                {
                   result +=input[j];
                }
                answer[i] = result;
            }

            for (int i = 0; i < answer.Length; i++)
            {
                WriteLine(answer[i]);
            }
        }
    }
}