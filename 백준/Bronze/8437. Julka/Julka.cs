using System;
using static System.Console;
using System.Numerics;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = BigInteger.Parse(ReadLine());
            BigInteger cloudia = BigInteger.Parse(ReadLine());
            BigInteger equals = (sum - cloudia)/2;
            WriteLine(equals + cloudia);
            WriteLine(equals);
        }
    }
}