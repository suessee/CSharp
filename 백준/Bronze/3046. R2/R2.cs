using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int R1 = int.Parse(num[0]), S = int.Parse(num[1]);
            
            WriteLine((S*2)-R1);

        }
    }
}