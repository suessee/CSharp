using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = ReadLine();
            string b = ReadLine();

            if (a.Length >= b.Length)
            {
                WriteLine("go");
            }
            else
            {
                WriteLine("no");
            }

        }
    }
}