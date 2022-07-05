using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Plane = ReadLine().Split();
            int n1 = int.Parse(Plane[0]), k1 = int.Parse(Plane[1]), n2 = int.Parse(Plane[2]), k2 = int.Parse(Plane[3]);
            WriteLine(n1 * k1 + n2 * k2);

        }
    }
}