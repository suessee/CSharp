using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int Sum = int.Parse(num[0]), Min = int.Parse(num[1]);
            if ((Sum - Min) % 2 != 0 || Min > Sum)
            {
                WriteLine(-1);
            }
            else
            {
                WriteLine(((Sum - Min) / 2) + Min + " "+ (Sum - Min) / 2);
            }
            

        }
    }
}