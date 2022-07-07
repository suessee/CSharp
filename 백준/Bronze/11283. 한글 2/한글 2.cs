using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string N = ReadLine();
            char[] answer = new char[11172];
            int cnt = 0;
            for (char i = '가'; i <= '힣'; i++)
            {
                answer[cnt] = i;
                cnt++;
            }
            for (int i = 0; i < answer.Length; i++)
            {
                if (string.Equals(answer[i].ToString(),N))
                {
                    WriteLine(i+1);
                }
            }
        }
    }
}