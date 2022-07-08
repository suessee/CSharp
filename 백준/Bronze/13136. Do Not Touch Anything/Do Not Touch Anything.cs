using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            long R = long.Parse(num[0]), C = long.Parse(num[1]), N = long.Parse(num[2]);
            long result = 0;

            if (R % N == 0)
            {
                if (C % N == 0)
                {
                    result = (R / N) * (C / N);
                }
                else
                {
                    result = (R / N) * ((C / N) + 1);
                }
            }
            else
            {
                if (C % N == 0)
                {
                    result = ((R / N) + 1) * (C / N);
                }
                else
                {
                    result = ((R / N) + 1) * ((C / N) + 1);
                }
            }
             
            WriteLine(result);

        }
    }
}