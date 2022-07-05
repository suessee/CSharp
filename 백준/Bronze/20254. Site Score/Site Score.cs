using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int UR = int.Parse(num[0]), TR = int.Parse(num[1]), UO = int.Parse(num[2]), TO = int.Parse(num[3]);
            int result = UR * 56 + TR * 24 + UO*14 + TO*6;
            WriteLine(result);
        }
    }
}