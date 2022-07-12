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
            if (A == 8 || A == 9)
            {
                if (B == C)
                {
                    if (D == 8 || D == 9)
                    {
                        WriteLine("ignore");
                    }
                    else
                    {
                        WriteLine("answer");
                    }
                }
                else
                {
                    WriteLine("answer");
                }
            }
            else
            {
                WriteLine("answer");
            }
        }
    }

}