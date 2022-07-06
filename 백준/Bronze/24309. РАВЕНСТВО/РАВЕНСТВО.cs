using System;
using static System.Console;
using System.Numerics;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(ReadLine());
            BigInteger b = BigInteger.Parse(ReadLine());
            BigInteger c = BigInteger.Parse(ReadLine());
            WriteLine((b-c)/a);
        }
    }
}
