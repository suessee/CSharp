using System;
using static System.Console;
using System.Numerics;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger Total = 0;
            for (int i = 0; i < 2; i++)
            {
                string[] num = ReadLine().Split();
                BigInteger V = BigInteger.Parse(num[0]), J = BigInteger.Parse(num[1]);
                Total += V * J;
            }
            string[] num1 = ReadLine().Split();
            BigInteger Vh = BigInteger.Parse(num1[0]), Dh = BigInteger.Parse(num1[1]), Jh = BigInteger.Parse(num1[2]);
            Total *= Vh * Dh * Jh;
            WriteLine(Total);
        }
    }
}