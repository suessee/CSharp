using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(ReadLine());
            string[] result = new string[T];
            for (int i = 0; i < T; i++)
            {
                string input = ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    if (j == 0 || j == input.Length-1)
                    {
                        result[i] += input[j];

                        if (j == input.Length - 1 && input.Length-1 == 0)
                        {
                            result[i] += input[j];
                        }
                    }
                }
                WriteLine(result[i]);
            }
        }
    }
}