using System;
using System.Numerics;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine()) % 20000303;
            Console.WriteLine(a);
        }
    }
}