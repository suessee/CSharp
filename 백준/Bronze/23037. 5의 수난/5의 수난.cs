using System;
using static System.Console;
using System.Numerics;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            BigInteger N = BigInteger.Parse(ReadLine());
            string nStr = N.ToString();
            double result = 0;
            for (int i = 0; i < nStr.Length; i++)
            { 
                result += Math.Pow(Char.GetNumericValue(nStr[i]),5);
            }
            WriteLine(result);
        }
    }
}