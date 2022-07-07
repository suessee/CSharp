using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] answer = new char[11172];
            int cnt = 0;
            for (char i = '가'; i <= '힣'; i++)
            {
                answer[cnt] = i;
                cnt++;
            }
            WriteLine(answer[N-1]);
        }
    }
}