using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int S = int.Parse(num[0]), T = int.Parse(num[1]), D = int.Parse(num[2]);
            int answer = (D / (S * 2)) * T;
            WriteLine(answer);
        }
    }
}