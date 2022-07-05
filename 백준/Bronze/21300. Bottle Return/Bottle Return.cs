using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int a = int.Parse(num[0]), b = int.Parse(num[1]), c = int.Parse(num[2]), d = int.Parse(num[3]), e = int.Parse(num[4]), f = int.Parse(num[5]);
            int result = a * 5 + b * 5 + c * 5 + d * 5 + e * 5 + f * 5;
            WriteLine(result);
        }
    }
}