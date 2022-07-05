using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(ReadLine());
            double case1 = N - (N * 0.22);
            double case2 = N*0.8 + (N - (N * 0.8) ) - ((N - (N * 0.8))* 0.22); 
            WriteLine("{0} {1}",case1, case2);
        }
    }
}