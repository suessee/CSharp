using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(ReadLine());
            int N = int.Parse(ReadLine());
            int Total = 0;
            for (int i = 0; i < N; i++)
            {
                string[] Obj = ReadLine().Split();
                int Price = int.Parse(Obj[0]), Num = int.Parse(Obj[1]);
                Total += Price * Num;
            }
            if (X == Total)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
        }
    }
}