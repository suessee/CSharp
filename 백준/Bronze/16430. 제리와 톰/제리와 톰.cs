using System;
using static System.Console;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]);
            WriteLine("{0} {1}", B-A, B);
        }
    }
}