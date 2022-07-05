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
            BigInteger A = BigInteger.Parse(num[0]), B = BigInteger.Parse(num[1]);
            WriteLine(A + B);
        }
    }
}