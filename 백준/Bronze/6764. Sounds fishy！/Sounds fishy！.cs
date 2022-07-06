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
            
            if (B > A)
            {
                if (C > B)
                {
                    if (D > C)
                    {
                        WriteLine("Fish Rising");
                    }
                    else
                    {
                        WriteLine("No Fish");
                    }
                }
                else
                {
                    WriteLine("No Fish");
                }
            }
            else if (A==B)
            {
                if (B == C)
                {
                    if (C == D)
                    {
                        WriteLine("Fish At Constant Depth");
                    }
                    else
                    {
                        WriteLine("No Fish");
                    }
                }
                else
                {
                    WriteLine("No Fish");
                }

            }
            else if (A > B)
            {
                if (B > C)
                {
                    if (C > D)
                    {
                        WriteLine("Fish Diving");
                    }
                    else
                    {
                        WriteLine("No Fish");
                    }
                }
                else
                {
                    WriteLine("No Fish");
                }
            }
        }
    }
}