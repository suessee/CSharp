using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            
            while (true)
            {
                string N = ReadLine();
                if (N == "END")
                {
                    break;
                }
                string answer = "";
                for (int i = N.Length-1; i >= 0; i--)
                {
                    answer += N[i];
                }
                WriteLine(answer);
            }
            
            
        }
    }
}