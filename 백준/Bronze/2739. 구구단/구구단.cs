using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(N + " * " + i + " = " + N * i);
            }
        }
    }
}