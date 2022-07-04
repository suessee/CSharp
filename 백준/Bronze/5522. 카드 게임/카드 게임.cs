using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(ReadLine());
                score += a;
            }
            WriteLine(score);
        }
    }
}