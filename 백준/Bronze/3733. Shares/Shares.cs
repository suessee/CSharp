using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    string[] num = input.Split();
                    WriteLine(int.Parse(num[1]) / (int.Parse(num[0]) + 1));
                }
                
            }
            
        }
    }
}