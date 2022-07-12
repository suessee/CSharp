using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());
            int E = int.Parse(ReadLine());
            int F = int.Parse(ReadLine());
            int Aresult = 3 * A + 2 * B + C;
            int Bresult = 3 * D + 2 * E + F;
            if (Aresult > Bresult)
            {
                WriteLine("A");
            }
            else if (Aresult < Bresult)
            {
                WriteLine("B");
            }
            else
            {
                WriteLine("T");
            }
        }
    }

}