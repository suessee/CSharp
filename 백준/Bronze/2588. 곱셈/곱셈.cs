using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int b0 = b / 100;
            int b1 = (b-b0*100) / 10;
            int b2 = (b - b0 * 100 - b1 * 10) / 1;
            Console.WriteLine(a * b2);
            Console.WriteLine(a * b1);
            Console.WriteLine(a * b0);
            Console.WriteLine(a * b);
        }
    }
}
