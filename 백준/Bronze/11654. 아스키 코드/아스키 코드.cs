using System;
using System.Text;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string A = ReadLine();
            foreach (var item in A)
            {
                WriteLine((int)item);
            }
        }
    }
}