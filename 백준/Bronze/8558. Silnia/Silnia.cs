using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            uint n = uint.Parse(ReadLine());
            int result = 1;
            for (int i = 1; i < n+1; i++)
            {
                result *= i;
            }
            string answer = result.ToString();
            if (answer.Length > 1)
            {
                for (int i = answer.Length - 1; i > 0; i--)
                {
                    WriteLine(answer[i]);
                    break;
                }
            }
            else
            {
                WriteLine(answer);
            }
            
        }
    }
}