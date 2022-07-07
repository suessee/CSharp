using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int a = int.Parse(num[0]), b = int.Parse(num[1]), c = int.Parse(num[2]);
            int result = 0;
            while (true)
            {
                if (a < b)
                {
                    a += c;
                    result += 1;
                }
                if (a >= b)
                {
                    break;
                }
            }
            
            WriteLine(result);
        }
    }
}