using System;
using static System.Console;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = ReadLine();
            int value = 0;

            for (int i = 0; i < str.Length; i++)
            {
                value = (value * 10 + (str[i] - '0')) % 20000303;
            }

            WriteLine(value);
        }
    }
}