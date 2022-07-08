using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string B1 = ReadLine();
            string B2 = ReadLine();

            long A = Convert.ToInt32(B1, 2);
            long C = Convert.ToInt32(B2, 2);
            string answer = Convert.ToString(A*C, 2);

            
            WriteLine(answer);
        }
    }
}