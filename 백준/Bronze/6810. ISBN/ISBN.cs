using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            
            int result = (9 * 1) + (7 * 3) + (8 * 1) + (0 * 3) + (9 * 1) + (2 * 3) + (1 * 1) + (4 * 3) + (1 * 1) + (8 * 3);
            result += (A * 1) + (B * 3) + (C * 1);
            WriteLine("The 1-3-sum is "+result);
        }
    }
}