using System;
using static System.Console;
using System.Numerics;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            BigInteger N = BigInteger.Parse(num[0]), M = BigInteger.Parse(num[1]);
            BigInteger A = BigInteger.Parse(ReadLine());
            BigInteger B = BigInteger.Parse(ReadLine());
            WriteLine(A*B);
        }
    }
}