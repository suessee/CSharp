using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            long a = long.Parse(num[0]), b = long.Parse(num[1]);
            long result = 0;
            if (a % 2 == 0 || b % 2 == 0)
            {
                result = 0;
            }
            else if (a > b)
            {
                if (a % 2 != 0)
                {
                    result = ((a - 1) / 2 + 1)*b - ((a - 1) / 2)*b;
                    
                }
                else
                {
                    result = 0;
                    
                }
            }
            else if(b >= a)
            {
                if (b % 2 != 0)
                {
                    result = ((b - 1) / 2 + 1) * a - ((b - 1) / 2) * a;

                }
                else
                {
                    result = 0;

                }
            }
            
            WriteLine(result);
        }
    }
}