using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String input = ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                WriteLine(input);
            }
        }
    }
}