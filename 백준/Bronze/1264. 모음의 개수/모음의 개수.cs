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
                int cnt = 0;
                string input = ReadLine();
                if (input == "#")
                {
                    break;
                }
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i'|| input[i] == 'o'|| input[i] == 'u'|| input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                    {
                        cnt += 1;
                    }
                }
                WriteLine(cnt);
            }
            
            
        }
    }
}