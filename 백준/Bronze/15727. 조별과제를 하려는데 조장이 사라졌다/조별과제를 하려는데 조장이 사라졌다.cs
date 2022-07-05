using System;
using static System.Console;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int walk = 5;
            int L = int.Parse(ReadLine());
            if (L % walk > 0)
            {
                WriteLine(L / walk + 1);
            }
            else
            {
                WriteLine(L / walk);
            }
        }
    }
}