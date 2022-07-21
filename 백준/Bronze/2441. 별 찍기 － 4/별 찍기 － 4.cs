using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            string a = " ";
            for (int i = 0; i < N; i++)
            {
                if (i > 0)
                {
                    Write(a);
                    a += " ";
                }
                for (int j = N - i; j > 0; j--)
                {
                     Write("*");
                }
                WriteLine();               
            }
        }
        
    }
}