using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string A = ReadLine();
            string B = ReadLine();
            string C = ReadLine();
            string D = ReadLine();
            string E = ReadLine();
            string F = ReadLine();
            string[] result = { A, B, C, D, E, F };
            int answer = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == "W")
                {
                    answer += 1;
                }
            }

            if (answer >= 5 && answer < 7)
            {
                WriteLine(1);
            }
            else if (answer >=3 && answer < 5)
            {
                WriteLine(2);
            }
            else if (answer >= 1 && answer < 3)
            {
                WriteLine(3);
            }
            else
            {
                WriteLine(-1);
            }
        }
    }
}