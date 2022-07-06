using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string result = "int";
            string lg = "long ";
            for (int i = 0; i < N/4; i++)
            {
                result = lg + result;
            }
            WriteLine(result);
        }
    }
}