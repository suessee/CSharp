using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int n1 = int.Parse(num[0]), n2 = int.Parse(num[1]), n12 = int.Parse(num[2]);
            int result = (n1 + 1)*(n2 + 1) / (n12 + 1) - 1;
            WriteLine(result);
        }
    }
}