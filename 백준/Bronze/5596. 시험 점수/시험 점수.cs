using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int S = 0;
            int T = 0;
            for (int i = 0; i < 2; i++)
            {
                string[] num = ReadLine().Split();
                int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]), D = int.Parse(num[3]);
                if (i == 0)
                {
                    S = A + B + C + D;
                }
                T = A + B + C + D;
            }
            if (S >= T)
            {
                WriteLine(S);
            }
            else
            {
                WriteLine(T);
            }
            

        }
    }
}