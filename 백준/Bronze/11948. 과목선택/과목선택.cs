using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());
            int E = int.Parse(ReadLine());
            int F = int.Parse(ReadLine());
            int[] AtoD = { A, B, C, D };
            Array.Sort(AtoD);
            int result = AtoD[1] + AtoD[2] + AtoD[3];
            if (E >= F)
            {
                WriteLine(result + E);
            }
            else
            {
                WriteLine(result + F);
            }
        }
    }
}