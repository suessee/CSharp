using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int cases = int.Parse(ReadLine());

            for (int i = 0; i < cases; i++)
            {
                int even = 0;
                int odd = 0;
                string[] num = ReadLine().Split();
                for (int j = 1; j < int.Parse(num[0]) + 1; j++)
                {
                    if (int.Parse(num[j]) % 2 == 0)
                    {
                        even += int.Parse(num[j]);
                    }
                    else
                    {
                        odd += int.Parse(num[j]);
                    }
                }
                if (even == odd)
                {
                    WriteLine("TIE");
                }
                else if (even > odd)
                {
                    WriteLine("EVEN");
                }
                else
                {
                    WriteLine("ODD");                  
                }
            }
        }
    }
}