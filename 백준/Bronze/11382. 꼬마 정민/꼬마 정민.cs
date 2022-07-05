using System;
using static System.Console;
using System.Numerics;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] input = ReadLine().Split();
            BigInteger A = BigInteger.Parse(input[0]), B = BigInteger.Parse(input[1]), C = BigInteger.Parse(input[2]);
            WriteLine(A + B + C);
        }
    }
}